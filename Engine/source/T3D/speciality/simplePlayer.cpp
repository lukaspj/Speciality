#include "simplePlayer.h"
#include "core/stream/bitStream.h"
#include "math/mathIO.h"

IMPLEMENT_CO_NETOBJECT_V1(SimplePlayer);
IMPLEMENT_CO_DATABLOCK_V1(SimplePlayerData);
IMPLEMENT_CONOBJECT(FeatureVector);

SimplePlayerData::SimplePlayerData()
{
   mMoveSpeed = 1.0f;
   mFriction = 0.1f;
}

SimplePlayerData::~SimplePlayerData()
{
   
}

void SimplePlayerData::initPersistFields()
{
   addField("MoveSpeed", TYPEID< F32 >(), Offset(mMoveSpeed, SimplePlayerData),
      "");
   addField("Friction", TYPEID< F32 >(), Offset(mFriction, SimplePlayerData),
      "");

   Parent::initPersistFields();
}

void SimplePlayerData::onRemove()
{
   Parent::onRemove();
}

bool SimplePlayerData::onAdd()
{
   return Parent::onAdd();
}

void SimplePlayerData::packData(BitStream* stream)
{
   Parent::packData(stream);
   stream->writeInt(mMoveSpeed*1000.0f, 28);
   stream->writeInt(mFriction*1000.0f, 28);
}

void SimplePlayerData::unpackData(BitStream* stream)
{
   Parent::unpackData(stream);
   mMoveSpeed = stream->readInt(28)/1000.0f;
   mFriction = stream->readInt(28)/1000.0f;
}


SimplePlayer::SimplePlayer()
{
   mVelocity = VectorF(0, 0, 0);
   mMovingLeft = false;
   mMovingRight = false;
   mMovingForward = false;
   mMovingBackward = false;

   mTickCount = 0;
}

SimplePlayer::~SimplePlayer()
{
   
}

void SimplePlayer::initPersistFields()
{
   addField("MovingForward", TYPEID< bool >(), Offset(mMovingForward, SimplePlayer),
      "");
   addField("MovingBackward", TYPEID< bool >(), Offset(mMovingBackward, SimplePlayer),
      "");
   addField("MovingRight", TYPEID< bool >(), Offset(mMovingRight, SimplePlayer),
      "");
   addField("MovingLeft", TYPEID< bool >(), Offset(mMovingLeft, SimplePlayer),
      "");
   addField("ThinkFunction", TypeCaseString, Offset(mThinkFunction, SimplePlayer), "");

   Parent::initPersistFields();
}

bool SimplePlayer::onAdd()
{
   if (!Parent::onAdd()) return false;

   // Setup our bounding box
   if (mDataBlock->mShape)
   {
      mObjBox = mDataBlock->mShape->bounds;
   }
   else
   {
      mObjBox = Box3F(Point3F(-1, -1, -1), Point3F(1, 1, 1));
   }

   if (mDataBlock->mShape)
   {
      //mShape = new TSShapeInstance(mDataBlock->shape, true);
   }
   resetWorldBox();

   addToScene();

   if (isServerObject())
   {
      scriptOnAdd();
   }


   return true;
}

void SimplePlayer::onRemove()
{
   Parent::onRemove();
   removeFromScene();
}

void SimplePlayer::advanceTime(F32 dt)
{
}

void SimplePlayer::doCollision(Point3F* newPos)
{
   Point3F currPos = getPosition();
   VectorF dir = *newPos - currPos;

   if (dir.magnitudeSafe() != 0.0f)
   {
      dir.normalizeSafe();
      Point3F extent = *newPos + dir * mObjBox.maxExtents;

      F32 totalDist = Point3F(extent - currPos).magnitudeSafe();
      F32 moveDist = Point3F(*newPos - currPos).magnitudeSafe();
      F32 movePercent = (moveDist / totalDist);

      RayInfo rInfo;
      U32 collisionMask = TerrainObjectType | StaticShapeObjectType | StaticObjectType;

      if (getContainer()->castRay(currPos, extent, collisionMask, &rInfo))
      {
         *newPos = currPos + dir * rInfo.t * movePercent;
         mVelocity -= mVelocity * rInfo.normal;
      }
   }
}

#define StokesDrag

void SimplePlayer::processTick(const Move* move)
{
   // apply gravity
   Point3F force = Point3F(0, 0, -9.81);

   Point3F moveAcceleration = Point3F(mMovingRight - mMovingLeft, mMovingForward - mMovingBackward, 0) * mDataBlock->getMoveSpeed() + force;

   mVelocity += moveAcceleration * TickSec - mVelocity * mDataBlock->getFriction();

   if (standingOnGround())
   {
      mVelocity.z = 0;
   }

   Point3F currPos = getPosition();
   Point3F newPos = currPos + mVelocity * TickSec;

   doCollision(&newPos);

   setPosition(newPos);
   setMaskBits(TransformMask);

   doThink();
}

void SimplePlayer::doThink()
{
   if (isServerObject() && mThinkFunction)
   {
      FeatureVector *features = new FeatureVector();
      features->registerObject();
      features->mTickCount = ++mTickCount;
      Actions action = EngineUnmarshallData< SimplePlayerActions >()(Con::executef(mThinkFunction, features).getStringValue());
      features->safeDeleteObject();
      mMovingLeft = false;
      mMovingRight = false;
      mMovingForward = false;
      mMovingBackward = false;
      switch (action)
      {
      case MoveForward:
         mMovingForward = true;
         break;
      case MoveBackward:
         mMovingBackward = true;
         break;
      case MoveLeft:
         mMovingLeft = true;
         break;
      case MoveRight:
         mMovingRight = true;
         break;
      default:
         break;
      }
   }
}

ImplementEnumType(SimplePlayerActions, "")
   { SimplePlayer::MoveLeft,     "MoveLeft", "\n" },
   { SimplePlayer::MoveRight,     "MoveRight", "\n" },
   { SimplePlayer::MoveForward,     "MoveForward", "\n" },
   { SimplePlayer::MoveBackward,     "MoveBackward", "\n" }
EndImplementEnumType;

bool SimplePlayer::onNewDataBlock(GameBaseData* dptr, bool reload)
{
   mDataBlock = dynamic_cast< SimplePlayerData* >(dptr);
   if (!mDataBlock || !Parent::onNewDataBlock(dptr, reload))
      return false;

   scriptOnNewDataBlock();
   return true;
}

U32 SimplePlayer::packUpdate(NetConnection* conn, U32 mask, BitStream* stream)
{
   U32 retMask = Parent::packUpdate(conn, mask, stream);

   if(stream->writeFlag(mask & TransformMask))
   {
      mathWrite(*stream, getTransform());
      mathWrite(*stream, getScale());
   }
   
   return retMask;
}

void SimplePlayer::unpackUpdate(NetConnection* conn, BitStream* stream)
{
   Parent::unpackUpdate(conn, stream);

   if(stream->readFlag())
   {
      MatrixF temp;
      Point3F tempScale;
      mathRead(*stream, &temp);
      mathRead(*stream, &tempScale);

      setScale(tempScale);
      setTransform(temp);
   }
}

bool SimplePlayer::standingOnGround()
{
   RayInfo rInfo;
   U32 collisionMask = TerrainObjectType | StaticShapeObjectType | StaticObjectType;

   Point3F target = getPosition();
   target.z -= mObjBox.maxExtents.z + 0.005;

   return getContainer()->castRay(getPosition(), target, collisionMask, &rInfo);
}

FeatureVector::FeatureVector()
{
}

FeatureVector::~FeatureVector()
{
}

void FeatureVector::initPersistFields()
{
   addField("TickCount", TypeS32, Offset(mTickCount, FeatureVector), "");
}



