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

   mShootDelay = 15;
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

   addField("ShootDelay", TYPEID< F32 >(), Offset(mShootDelay, SimplePlayerData),
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
   stream->write(mShootDelay);
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
   stream->read(&mShootDelay);
}


SimplePlayer::SimplePlayer()
{
   mTypeMask |= PlayerObjectType;

   mVelocity = VectorF(0, 0, 0);
   mMovingLeft = false;
   mMovingRight = false;
   mMovingForward = false;
   mMovingBackward = false;

   mRot = 0.0f;
   mHealth = 20.0f;

   mPrepared = false;
   mLastRot = 0.0f;
   mLastPosX = 0.0f;
   mLastPosY = 0.0f;

   mLastHealth = 20.0f;

   mTimeSawEnemy = S32_MIN;
   mTimeTookDamage = S32_MIN;
   mShootDelay = S32_MIN;

   mRenderFrustum = false;
   mRenderDistance = false;

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
   addField("RenderDistance", TYPEID< bool >(), Offset(mRenderDistance, SimplePlayer),
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

F32 SimplePlayer::getDistanceToObstacleInFront()
{
   F32 width = mObjBox.maxExtents.x;
   F32 depth = mObjBox.maxExtents.y;
   F32 height = mObjBox.maxExtents.z;
   MatrixF mat = getTransform();
   Point3F leftPoint = Point3F(-width, depth, height / 2);
   Point3F rightPoint = Point3F(width, depth, height / 2);
   mat.mulP(leftPoint);
   mat.mulP(rightPoint);

   Point3F dir = getTransform().getForwardVector();
   RayInfo rInfo;

   F32 dist1 = 0.0f, dist2 = 0.0f;

   disableCollision();
   if (getContainer()->castRay(leftPoint, leftPoint + (dir * 100), CollisionMoveMask, &rInfo))
      dist1 = rInfo.distance;
   if (getContainer()->castRay(rightPoint, rightPoint + (dir * 100), CollisionMoveMask, &rInfo))
      dist2 = rInfo.distance;
   enableCollision();

   return dist1 > dist2 ? dist2 : dist1;
}

void SimplePlayer::processTick(const Move* move)
{
   // apply gravity
   Point3F force = Point3F(0, 0, -9.81);

   Point3F moveAcceleration = Point3F(mMovingRight - mMovingLeft, mMovingForward - mMovingBackward, 0) * mDataBlock->getMoveSpeed();

   MatrixF trans = getTransform();
   MatrixF mat;
   AngAxisF::RotateZ(mRot, &mat);
   mat.mulV(moveAcceleration);
   trans.mul(mat);
   setTransform(trans);

   VectorF acceleration = moveAcceleration + force;

   mVelocity += acceleration * TickSec - mVelocity * mDataBlock->getFriction();

   if(standingOnGround())
   {
      mVelocity.z = 0.0f;
   }


   mCollision.update();
   updatePosition(TickSec);

   doThink();
}


ImplementEnumType(SimplePlayerActions, "")
{ SimplePlayer::MoveLeft, "MoveLeft", "\n" },
{ SimplePlayer::MoveRight,     "MoveRight", "\n" },
{ SimplePlayer::MoveForward,     "MoveForward", "\n" },
{ SimplePlayer::MoveBackward,     "MoveBackward", "\n" },
{ SimplePlayer::TurnRight,     "TurnRight", "\n" },
{ SimplePlayer::TurnLeft,     "TurnLeft", "\n" },
{ SimplePlayer::Shoot,     "Shoot", "\n" },
{ SimplePlayer::Prepare,     "Prepare", "\n" }
EndImplementEnumType;

void SimplePlayer::doThink()
{
   if (isServerObject() && mThinkFunction)
   {
      if (!mHasThoughtOnce)
      {
         mHasThoughtOnce = true;
         mLastRot = mRot;
         mLastPosX = getPosition().x;
         mLastPosY = getPosition().y;
      }

      F32 killProb = 0.0f; // todo Support more players?

      SimGroup *playersGroup = static_cast<SimGroup*>(Sim::findObject("Players"));
      for(int i = 0; i < playersGroup->size(); i++)
      {
         SimplePlayer *player = static_cast<SimplePlayer*>((*playersGroup)[i]);
         if (player == this) continue;

         //killProb = Con::executef("GetDamagePropability", this, player).getFloatValue();
      }

      FeatureVector *features = new FeatureVector();
      features->registerObject();

      features->mDeltaRot = mLastRot - mRot;
      features->mDeltaMovedX = mLastPosX - getPosition().x;
      features->mDeltaMovedY = mLastPosY - getPosition().y;
      features->mVelX = getVelocity().x;
      features->mVelY = getVelocity().y;

      features->mKillProb = killProb;
      features->mDistanceToObstacle = getDistanceToObstacleInFront();
      features->mHealth = mHealth;

      features->mTickCount = ++mTickCount;
      features->mTicksSinceDamage = mTickCount - mTimeTookDamage;
      features->mTicksSinceObservedEnemy = mTickCount - mTimeSawEnemy;
      features->mShootDelay = mShootDelay;
      Actions action = EngineUnmarshallData< SimplePlayerActions >()(Con::executef(mThinkFunction, features).getStringValue());
      features->safeDeleteObject();

      mLastRot = mRot;
      mLastPosX = getPosition().x;
      mLastPosY = getPosition().y;
      mShootDelay = mShootDelay <= 0 ? 0 : --mShootDelay;
      if(mHealth != mLastHealth)
      {
         mTimeTookDamage = mTickCount;
      }

      mMovingLeft = false;
      mMovingRight = false;
      mMovingForward = false;
      mMovingBackward = false;
      if (mPrepared)
      {
         mPrepared = false;
         doThink();
      }
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
      case TurnLeft:
         mRot -= mDataBlock->getTurnSpeed();
         break;
      case Shoot:
         Shoot_callback();
         mShootDelay = mDataBlock->getShootDelay();
         break;
      case Prepare:
         mPrepared = true;
         break;
      default:
         break;
      }
   }
}

IMPLEMENT_CALLBACK(SimplePlayer, Shoot, void, (), (),
   "");

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
   GFXDrawUtil* du = GFX->getDrawUtil();
   if(mRenderFrustum)
   {
      MatrixF trans;
      getEyeTransform(&trans);

      Frustum frustum;
      frustum.set(false, getDataBlock()->getFOV(), getDataBlock()->getAspectRatio(), getDataBlock()->getNearDist(), getDataBlock()->getFarDist(), trans);

      du->drawFrustum(frustum, ColorI(200, 70, 50, 150));
   }

   if(mRenderDistance)
   {
      F32 width = mObjBox.maxExtents.x;
      F32 depth = mObjBox.maxExtents.y;
      F32 height = mObjBox.maxExtents.z;
      MatrixF mat = getTransform();
      Point3F leftPoint = Point3F(-width, depth, height / 2);
      Point3F rightPoint = Point3F(width, depth, height / 2);
      mat.mulP(leftPoint);
      mat.mulP(rightPoint);

      Point3F dir = getTransform().getForwardVector();
      RayInfo rInfo;

      disableCollision();
      if (getContainer()->castRay(leftPoint, leftPoint + (dir * 100), CollisionMoveMask, &rInfo))
         du->drawLine(leftPoint, rInfo.point, ColorI::GREEN);
      if (getContainer()->castRay(rightPoint, rightPoint + (dir * 100), CollisionMoveMask, &rInfo))
         du->drawLine(rightPoint, rInfo.point, ColorI::GREEN);
      enableCollision();
   }
}

bool SimplePlayer::standingOnGround()
{
   RayInfo rInfo;

   Point3F target = getPosition();
   target.z -= mObjBox.maxExtents.z + 0.005;

   return getContainer()->castRay(getPosition(), target, CollisionMoveMask, &rInfo);
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
      stream->writeFlag(mRenderFrustum);
      stream->writeFlag(mRenderDistance);
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
      mRenderFrustum = stream->readFlag();
      mRenderDistance = stream->readFlag();
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

DefineEngineMethod(SimplePlayer, GetEulerRotation, Point3F, (), , "")
{
   return object->getTransform().toEuler();
}

FeatureVector::FeatureVector()
{
}

FeatureVector::~FeatureVector()
{
}

void FeatureVector::initPersistFields()
{
   addField("DeltaRot", TypeF32, Offset(mDeltaRot, FeatureVector), "");
   addField("DeltaMovedX", TypeF32, Offset(mDeltaMovedX, FeatureVector), "");
   addField("DeltaMovedY", TypeF32, Offset(mDeltaMovedY, FeatureVector), "");
   addField("VelX", TypeF32, Offset(mVelX, FeatureVector), "");
   addField("VelY", TypeF32, Offset(mVelY, FeatureVector), "");

   addField("KillProb", TypeF32, Offset(mKillProb, FeatureVector), "");
   addField("DistanceToObstacle", TypeF32, Offset(mDistanceToObstacle, FeatureVector), "");
   addField("Health", TypeF32, Offset(mHealth, FeatureVector), "");

   addField("TickCount", TypeS32, Offset(mTickCount, FeatureVector), "");
   addField("TicksSinceObservedEnemy", TypeS32, Offset(mTicksSinceObservedEnemy, FeatureVector), "");
   addField("TicksSinceDamage", TypeS32, Offset(mTicksSinceDamage, FeatureVector), "");
   addField("ShootDelay", TypeS32, Offset(mShootDelay, FeatureVector), "");

   Parent::initPersistFields();
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
