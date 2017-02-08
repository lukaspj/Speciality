#include "simplePlayer.h"
#include "core/stream/bitStream.h"
#include "math/mathIO.h"
#include "materials/baseMatInstance.h"
#include "gfx/gfxDrawUtil.h"

IMPLEMENT_CO_NETOBJECT_V1(SimplePlayer);
IMPLEMENT_CO_DATABLOCK_V1(SimplePlayerData);
IMPLEMENT_CONOBJECT(FeatureVector);

SimplePlayerData::SimplePlayerData()
{
   mMoveSpeed = 1.0f;
   mTurnSpeed = 1.0f;
   mFriction = 0.1f;

   mFOV = 70.0f;
   mAspectRatio = 1.0f;
   mNearDist = 0.5f;
   mFarDist = 200.0f;
}

SimplePlayerData::~SimplePlayerData()
{
   
}

void SimplePlayerData::initPersistFields()
{
   addField("MoveSpeed", TYPEID< F32 >(), Offset(mMoveSpeed, SimplePlayerData),
            "");
   addField("TurnSpeed", TYPEID< F32 >(), Offset(mTurnSpeed, SimplePlayerData),
            "");
   addField("Friction", TYPEID< F32 >(), Offset(mFriction, SimplePlayerData),
            "");

   addField("FOV", TYPEID< F32 >(), Offset(mFOV, SimplePlayerData),
            "");
   addField("AspectRatio", TYPEID< F32 >(), Offset(mAspectRatio, SimplePlayerData),
            "");
   addField("NearDist", TYPEID< F32 >(), Offset(mNearDist, SimplePlayerData),
            "");
   addField("FarDist", TYPEID< F32 >(), Offset(mFarDist, SimplePlayerData),
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
   stream->write(mTurnSpeed);
   stream->write(mFOV);
   stream->write(mAspectRatio);
   stream->write(mNearDist);
   stream->write(mFarDist);
}

void SimplePlayerData::unpackData(BitStream* stream)
{
   Parent::unpackData(stream);
   mMoveSpeed = stream->readInt(28)/1000.0f;
   mFriction = stream->readInt(28)/1000.0f;
   stream->read(&mTurnSpeed);
   stream->read(&mFOV);
   stream->read(&mAspectRatio);
   stream->read(&mNearDist);
   stream->read(&mFarDist);
}


SimplePlayer::SimplePlayer()
{
   mVelocity = VectorF(0, 0, 0);
   mMovingLeft = false;
   mMovingRight = false;
   mMovingForward = false;
   mMovingBackward = false;

   mRot = 0.0f;

   mRenderFrustum = false;

   mTickCount = 0;
   mThinkFunction = NULL;

   CollisionMoveMask = (TerrainObjectType | PlayerObjectType |
      StaticShapeObjectType | VehicleObjectType |
      VehicleBlockerObjectType | DynamicShapeObjectType | StaticObjectType | EntityObjectType | TriggerObjectType);
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
   addField("RenderFrustum", TYPEID< bool >(), Offset(mRenderFrustum, SimplePlayer),
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

   if (isServerObject())
      mCollision.prepCollision(this);

   return true;
}

void SimplePlayer::onRemove()
{
   Parent::onRemove();
   removeFromScene();
   mCollision.safeDelete();
   disableCollision();
}

void SimplePlayer::advanceTime(F32 dt)
{
}

void SimplePlayer::processTick(const Move* move)
{
   // apply gravity
   Point3F force = Point3F(0, 0, -9.81);

   Point3F moveAcceleration = Point3F(mMovingRight - mMovingLeft, mMovingForward - mMovingBackward, 0) * mDataBlock->getMoveSpeed() + force;

   mVelocity += moveAcceleration * TickSec - mVelocity * mDataBlock->getFriction();

   if(standingOnGround())
   {
      mVelocity.z = 0.0f;
   }


   mCollision.update();
   updatePosition(TickSec);

   doThink();
}


ImplementEnumType(SimplePlayerActions, "")
{
   SimplePlayer::MoveLeft, "MoveLeft", "\n"
},
{ SimplePlayer::MoveRight,     "MoveRight", "\n" },
{ SimplePlayer::MoveForward,     "MoveForward", "\n" },
{ SimplePlayer::MoveBackward,     "MoveBackward", "\n" },
{ SimplePlayer::TurnRight,     "TurnRight", "\n" }
   EndImplementEnumType;

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
      case TurnRight:
         mRot += mDataBlock->getTurnSpeed();
         break;
      default:
         break;
      }
   }
}

void SimplePlayer::updatePosition(const F32 travelTime)
{
   Point3F newPos;

   newPos = _move(travelTime);

   setPosition(newPos);
   MatrixF mat;
   mat.set(EulerF(0.0f, 0.0f, mRot));
   mat.setColumn(3, newPos);
   setTransform(mat);
   setMaskBits(TransformMask);
}

void SimplePlayer::prepRenderImage(SceneRenderState* state)
{
   ObjectRenderInst *ori = state->getRenderPass()->allocInst<ObjectRenderInst>();
   ori->renderDelegate.bind(this, &SimplePlayer::debugRenderDelegate);
   ori->type = RenderPassManager::RIT_Editor;
   state->getRenderPass()->addInst(ori);

   Parent::prepRenderImage(state);
}

void SimplePlayer::debugRenderDelegate(ObjectRenderInst* ri, SceneRenderState* state, BaseMatInstance* overrideMat)
{
   if(mRenderFrustum)
   {
      MatrixF trans;
      getEyeTransform(&trans);

      Frustum frustum;
      frustum.set(false, getDataBlock()->getFOV(), getDataBlock()->getAspectRatio(), getDataBlock()->getNearDist(), getDataBlock()->getFarDist(), trans);

      GFXDrawUtil* du = GFX->getDrawUtil();
      du->drawFrustum(frustum, ColorI(200, 70, 50, 150));
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

   if(stream->writeFlag(mask & InitialUpdateMask))
   {
      stream->writeString(mThinkFunction);
   }

   if(stream->writeFlag(mask & TransformMask))
   {
      mathWrite(*stream, getTransform());
      mathWrite(*stream, getScale());
      stream->write(mRot);
   }
   
   return retMask;
}

void SimplePlayer::unpackUpdate(NetConnection* conn, BitStream* stream)
{
   Parent::unpackUpdate(conn, stream);

   if(stream->readFlag())
   {
      char buffer[256];
      stream->readString(buffer);
      mThinkFunction = buffer;
   }

   if(stream->readFlag())
   {
      MatrixF temp;
      Point3F tempScale;
      mathRead(*stream, &temp);
      mathRead(*stream, &tempScale);
      stream->read(&mRot);

      setScale(tempScale);
      setTransform(temp);
   }
}

DefineEngineMethod(SimplePlayer, CanSee, bool, (SceneObject* other), , "")
{
   Frustum frustum;
   frustum.set(false, object->getDataBlock()->getFOV(), object->getDataBlock()->getAspectRatio(), object->getDataBlock()->getNearDist(), object->getDataBlock()->getFarDist(), object->getTransform());
   return frustum.isCulled(other->getObjBox());
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

///////////////////////////////////////////////////////////////////////////////////
//  COLLISION  ////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////


void SimplePlayer::handleCollision(Collision& col, VectorF velocity)
{
   if (col.object && (mCollision.getContactInfo().contactObject == NULL ||
      col.object->getId() != mCollision.getContactInfo().contactObject->getId()))
   {
      queueCollision(col.object, velocity - col.object->getVelocity());

      //do the callbacks to script for this collision
      if (isMethod("onCollision"))
      {
         S32 matId = col.material != NULL ? col.material->getMaterial()->getId() : 0;
         Con::executef(this, "onCollision", col.object, col.normal, col.point, matId, velocity);
      }

      if (isMethod("onCollisionEvent"))
      {
         S32 matId = col.material != NULL ? col.material->getMaterial()->getId() : 0;
         Con::executef(this, "onCollisionEvent", col.object, col.normal, col.point, matId, velocity);
      }
   }
}

Point3F SimplePlayer::_move(const F32 travelTime)
{

   // Try and move to new pos
   F32 totalMotion = 0.0f;

   Point3F start;
   Point3F initialPosition;
   getTransform().getColumn(3, &start);
   initialPosition = start;

   VectorF firstNormal(0.0f, 0.0f, 0.0f);
   F32 time = travelTime;
   U32 count = 0;
   S32 sMoveRetryCount = 5;

   mCollision.getCollisionList().clear();

   for (; count < sMoveRetryCount; count++)
   {
      F32 speed = mVelocity.len();
      if (!speed)
         break;

      Point3F end = start + mVelocity * time;

      bool collided = mCollision.checkCollisions(time, &mVelocity, start);

      if (mCollision.getCollisionList().getCount() != 0 && mCollision.getCollisionList().getTime() < 1.0f)
      {
         // Set to collision point
         F32 velLen = mVelocity.len();

         F32 dt = time * getMin(mCollision.getCollisionList().getTime(), 1.0f);
         start += mVelocity * dt;
         time -= dt;

         totalMotion += velLen * dt;

         // Back off...
         if (velLen > 0.f)
         {
            F32 newT = getMin(0.01f / velLen, dt);
            start -= mVelocity * newT;
            totalMotion -= velLen * newT;
         }

         const Collision *collision = &mCollision.getCollisionList()[0];
         const Collision *cp = collision + 1;
         const Collision *ep = collision + mCollision.getCollisionList().getCount();
         for (; cp != ep; cp++)
         {
            if (cp->faceDot > collision->faceDot)
               collision = cp;
         }

         F32 bd = -mDot(mVelocity, collision->normal);

         // Subtract out velocity
         F32 sNormalElasticity = 0.01f;
         VectorF dv = collision->normal * (bd + sNormalElasticity);
         mVelocity += dv;
         if (count == 0)
         {
            firstNormal = collision->normal;
         }
         else
         {
            if (count == 1)
            {
               // Re-orient velocity along the crease.
               if (mDot(dv, firstNormal) < 0.0f &&
                  mDot(collision->normal, firstNormal) < 0.0f)
               {
                  VectorF nv;
                  mCross(collision->normal, firstNormal, &nv);
                  F32 nvl = nv.len();
                  if (nvl)
                  {
                     if (mDot(nv, mVelocity) < 0.0f)
                        nvl = -nvl;
                     nv *= mVelocity.len() / nvl;
                     mVelocity = nv;
                  }
               }
            }
         }
      }
      else
      {
         start = end;
         break;
      }
   }

   if (count == sMoveRetryCount)
   {
      // Failed to move
      start = initialPosition;
      mVelocity.set(0.0f, 0.0f, 0.0f);
   }

   return start;
}