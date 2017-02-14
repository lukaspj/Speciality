#include "simplePlayerCollision.h"
#include "collision/boxConvex.h"
#include "T3D/physics/physicsPlugin.h"
#include "T3D/physics/physicsCollision.h"
#include "collision/earlyOutPolyList.h"
#include "T3D/trigger.h"
#include "collision/extrudedPolyList.h"
#include "simplePlayer.h"

SimplePlayerCollision::SimplePlayerCollision()
{
   mOwner = NULL;
   mConvexList = NULL;
   mPhysicsRep = NULL;

   mColliderScale = Point3F(1, 1, 1);

   mWorkingQueryBox.minExtents.set(-1e9f, -1e9f, -1e9f);
   mWorkingQueryBox.maxExtents.set(-1e9f, -1e9f, -1e9f);
}

void SimplePlayerCollision::prepCollision(SimplePlayer* owner)
{
   mOwner = owner;

   // Allow the ShapeInstance to prep its collision if it hasn't already
   if (mColliderScale.isZero()) {
      mOwner->disableCollision();
      return;
   }

   if (mConvexList != NULL)
      mConvexList->nukeList();

   BoxConvex* bC = new BoxConvex();
   bC->init(mOwner);
   bC->mSize = mColliderScale;
   mOwner->getObjBox().getCenter(&bC->mCenter);
   mConvexList = bC;

   Box3F colliderBounds = bC->getBoundingBox(mOwner->getTransform(), mOwner->getScale());

   Box3F ownerBounds = mOwner->getWorldBox();

   if (!ownerBounds.isContained(colliderBounds))
   {
      Box3F newBounds = ownerBounds;

      newBounds.extend(colliderBounds.minExtents);
      newBounds.extend(colliderBounds.maxExtents);

      mOwner->setObjBox(newBounds);
   }

   mOwner->enableCollision();
   _updatePhysics();
}

void SimplePlayerCollision::update()
{
   //ProcessTick is where our collision testing begins!

   //First, we clear our old collision list. We do this, because if we're still colliding with something, 
   //it'll be added back in, but we don't want to risk colliding with something we've moved past
   //mCollisionList.clear();

   //If we're not moving, or we never made any convex elements, we won't bother updating out working set
   if (mConvexList && mConvexList->getObject() && !mOwner->getVelocity().isZero())
      updateWorkingCollisionSet((U32)-1);
}

bool SimplePlayerCollision::checkCollisions(const F32 travelTime, Point3F* velocity, Point3F start)
{
   //Check collisions is inherited down from our interface. It's the main method for invoking collisions checks from other components

   //First, the obvious confirmation that we even have our convexes set up. If not, we can't be collided with, so bail out now.
   if (!mConvexList || !mConvexList->getObject())
      return false;

   //The way this is checked, is we build an estimate of where the end point of our owner will be based on the provided starting point, velocity and time
   Point3F end = start + *velocity * travelTime;

   //Build our vector of movement off that
   VectorF vector = end - start;

   //Now, as we're doing a new collision, any old collision information we had is no longer needed, so we can clear our collisionList in anticipation
   //of it being updated
   //mCollisionList.clear();

   U32 sCollisionMoveMask = TerrainObjectType |
      WaterObjectType |
      PlayerObjectType |
      StaticShapeObjectType |
      VehicleObjectType |
      PhysicalZoneObjectType |
      TriggerObjectType;

   //We proceed to use our info above with our owner's properties to do an early out test against our working set we created earlier.
   //This is a simplified version of the checks we do later, so it's cheaper. If we can early out on the cheaper check now, we save a lot
   //of time and processing.
   //We only do the 'real' collision checks if we detect we might hit something after all when doing the early out.
   //See the checkEarlyOut function in the CollisionInterface for an explination on how it works.
   if (checkEarlyOut(start, *velocity, travelTime, mOwner->getObjBox(), mOwner->getScale(), mConvexList->getBoundingBox(), 0xFFFFFF, mConvexList->getWorkingList()))
      //if (checkEarlyOut(start, *velocity, travelTime, mOwner->getObjBox(), mOwner->getScale(), mConvexList->getBoundingBox(), sCollisionMoveMask, mConvexList->getWorkingList()))
      return false;

   //If we've made it this far, there's a very good chance we can actually collide with something in our working list. 
   //As such, go ahead and do our real collision update now
   bool collided = updateCollisions(travelTime, vector, *velocity);

   //Once that's been done, we proceed to handle our collision list, to notify any collidees.
   handleCollisionList(mCollisionList, *velocity);

   //This is only partially implemented.
   //The idea will be that you can define on a collider if it actually blocks when a collision occurs.
   //This would let colliders act as normal collision objects, or act as triggers.
   return collided;
}

void SimplePlayerCollision::updateWorkingCollisionSet(const U32 mask)
{
   //UpdateWorkingCollisionSet
   //What we do here, is check our estimated path along the current tick based on our
   //position, velocity, and tick time
   //From that information, we check other entities in our bin that we may potentially collide against

   // First, we need to adjust our velocity for possible acceleration.  It is assumed
   // that we will never accelerate more than 20 m/s for gravity, plus 10 m/s for
   // jetting, and an equivalent 10 m/s for jumping.  We also assume that the
   // working list is updated on a Tick basis, which means we only expand our
   // box by the possible movement in that tick.
   VectorF velocity = mOwner->getVelocity();

   Point3F scaledVelocity = velocity * TickSec;
   F32 len = scaledVelocity.len();
   F32 newLen = len + (10.0f * TickSec);

   // Check to see if it is actually necessary to construct the new working list,
   // or if we can use the cached version from the last query.  We use the x
   // component of the min member of the mWorkingQueryBox, which is lame, but
   // it works ok.
   bool updateSet = false;

   Box3F convexBox = mConvexList->getBoundingBox(mOwner->getTransform(), mOwner->getScale());
   F32 l = (newLen * 1.1f) + 0.1f;  // from Convex::updateWorkingList
   const Point3F  lPoint(l, l, l);
   convexBox.minExtents -= lPoint;
   convexBox.maxExtents += lPoint;

   // Check containment
   if (mWorkingQueryBox.minExtents.x != -1e9f)
   {
      if (mWorkingQueryBox.isContained(convexBox) == false)
         // Needed region is outside the cached region.  Update it.
         updateSet = true;
   }
   else
   {
      // Must update
      updateSet = true;
   }
   // Actually perform the query, if necessary
   if (updateSet == true) {
      const Point3F  twolPoint(2.0f * l, 2.0f * l, 2.0f * l);
      mWorkingQueryBox = convexBox;
      mWorkingQueryBox.minExtents -= twolPoint;
      mWorkingQueryBox.maxExtents += twolPoint;

      //So first we scale our workingQueryBox to catch everything we may potentially collide with this tick
      //Then disable our entity owner so we don't run into it like an idiot
      mOwner->disableCollision();

      //Now we officially update our working list.
      //What this basically does is find any objects our working box(which, again, is our theoretical collision space)
      //and has them call buildConvex().
      //This makes them update their convex information so we can check if we actually collide with it for real)
      mConvexList->updateWorkingList(mWorkingQueryBox, U32(-1));

      //Once we've updated, re-enable our entity owner's collision so that other things can collide with us if needed
      mOwner->enableCollision();
   }
}

void SimplePlayerCollision::_updatePhysics()
{
   SAFE_DELETE(mPhysicsRep);

   if (!PHYSICSMGR)
      return;

   PhysicsCollision *colShape = NULL;
   MatrixF offset(true);
   offset.setPosition(mOwner->getPosition());
   colShape = PHYSICSMGR->createCollision();
   //colShape->addBox( mOwner->getObjBox().getExtents() * 0.5f * mOwner->getScale(), offset ); 
   colShape->addBox(mColliderScale, offset);

   if (colShape)
   {
      PhysicsWorld *world = PHYSICSMGR->getWorld(mOwner->isServerObject() ? "server" : "client");
      mPhysicsRep = PHYSICSMGR->createBody();
      mPhysicsRep->init(colShape, 0, 0, mOwner, world);
      mPhysicsRep->setTransform(mOwner->getTransform());
   }
}

bool SimplePlayerCollision::checkEarlyOut(Point3F start, VectorF velocity, F32 time, Box3F objectBox, Point3F objectScale, Box3F collisionBox, U32 collisionMask, CollisionWorkingList& colWorkingList)
{
   Point3F end = start + velocity * time;
   Point3F distance = end - start;

   if (mFabs(distance.x) < objectBox.len_x() &&
      mFabs(distance.y) < objectBox.len_y() &&
      mFabs(distance.z) < objectBox.len_z())
   {
      // We can potentially early out of this.  If there are no polys in the clipped polylist at our
      //  end position, then we can bail, and just set start = end;
Box3F scaledBox = objectBox;
      scaledBox.minExtents.convolve(objectScale);
      scaledBox.maxExtents.convolve(objectScale);

      Box3F wBox = scaledBox;
      mOwner->getTransform().mul(wBox);
      wBox.minExtents += distance;
      wBox.maxExtents += distance;

      static EarlyOutPolyList eaPolyList;
      eaPolyList.clear();
      eaPolyList.mNormal.set(0.0f, 0.0f, 0.0f);
      eaPolyList.mPlaneList.clear();
      eaPolyList.mPlaneList.setSize(6);

      VectorF plane1 = VectorF(1.0f, 0.0f, 0.0f);
      VectorF plane2 = VectorF(0.0f, 1.0f, 0.0f);
      VectorF plane3 = VectorF(0.0f, 0.0f, 1.0f);

      mOwner->getTransform().mulV(plane1);
      mOwner->getTransform().mulV(plane2);
      mOwner->getTransform().mulV(plane3);

      eaPolyList.mPlaneList[0].set(wBox.minExtents, -plane1);
      eaPolyList.mPlaneList[1].set(wBox.maxExtents, plane2);
      eaPolyList.mPlaneList[2].set(wBox.maxExtents, plane1);
      eaPolyList.mPlaneList[3].set(wBox.minExtents, -plane2);
      eaPolyList.mPlaneList[4].set(wBox.minExtents, -plane3);
      eaPolyList.mPlaneList[5].set(wBox.maxExtents, plane3);

      // Build list from convex states here...
      CollisionWorkingList& rList = colWorkingList;
      CollisionWorkingList* pList = rList.wLink.mNext;
      while (pList != &rList)
      {
         Convex* pConvex = pList->mConvex;

         if (pConvex->getObject()->getTypeMask() & collisionMask)
         {
            Box3F convexBox = pConvex->getBoundingBox();

            if (wBox.isOverlapped(convexBox))
            {
               // No need to separate out the physical zones here, we want those
               //  to cause a fallthrough as well...
               pConvex->getPolyList(&eaPolyList);
            }
         }
         pList = pList->wLink.mNext;
      }

      if (eaPolyList.isEmpty())
      {
         return true;
      }
   }

   return false;
}

bool SimplePlayerCollision::updateCollisions(const F32 travelTime, Point3F vector, Point3F velocity)
{
   Polyhedron cPolyhedron;
   cPolyhedron.buildBox(mOwner->getTransform(), mOwner->getObjBox(), true);
   ExtrudedPolyList extrudePoly;

   extrudePoly.extrude(cPolyhedron, velocity);
   extrudePoly.setVelocity(velocity);
   extrudePoly.setCollisionList(&mCollisionList);

   Box3F plistBox = mOwner->getObjBox();
   mOwner->getTransform().mul(plistBox);
   Point3F oldMin = plistBox.minExtents;
   Point3F oldMax = plistBox.maxExtents;
   plistBox.minExtents.setMin(oldMin + (velocity * travelTime) - Point3F(0.1f, 0.1f, 0.1f));
   plistBox.maxExtents.setMax(oldMax + (velocity * travelTime) + Point3F(0.1f, 0.1f, 0.1f));

   // Build list from convex states here...
   CollisionWorkingList& rList = mConvexList->getWorkingList();
   CollisionWorkingList* pList = rList.wLink.mNext;
   while (pList != &rList)
   {
      Convex* pConvex = pList->mConvex;
      SceneObject* scObj = pConvex->getObject();

      if (pConvex->getObject()->getTypeMask() & mOwner->CollisionMoveMask)
      {
         Box3F convexBox = pConvex->getBoundingBox();
         if (plistBox.isOverlapped(convexBox))
         {
            pConvex->getPolyList(&extrudePoly);
         }
      }
      pList = pList->wLink.mNext;
   }

   if (mCollisionList.getCount() > 0)
   {
      for (U32 i = 0; i < mCollisionList.getCount(); i++)
      {
         if (dynamic_cast<Trigger*>(mCollisionList[i].object))
            return false;
      }

      return true;
   }

   return false;
}

void SimplePlayerCollision::handleCollisionList(CollisionList& collisionList, VectorF velocity)
{
   Collision bestCol;

   //if (collisionList.getCount() > 0)
   //   bestCol = collisionList[collisionList.getCount() - 1];

   for (U32 i = 0; i < collisionList.getCount(); ++i)
   {
      Collision& colCheck = collisionList[i];

      if (colCheck.object)
      {
         if (colCheck.object->getTypeMask() & PlayerObjectType)
         {
            mOwner->handleCollision(colCheck, velocity);
         }
         else if (colCheck.object->getTypeMask() & TriggerObjectType)
         {
            // We've hit it's bounding box, that's close enough for triggers
            Trigger* pTrigger = static_cast<Trigger*>(colCheck.object);

            pTrigger->potentialEnterObject(mOwner);
         }
         /*else if(colCheck.object->getTypeMask() & EntityObjectType)
         {
         Entity* ent = dynamic_cast<Entity*>(colCheck.object);
         if (ent)
         {
         CollisionInterface *colObjectInterface = ent->getComponent<CollisionInterface>();
         if (colObjectInterface)
         {
         //convert us to our component
         Component *thisComp = dynamic_cast<Component*>(this);
         if (thisComp)
         {
         colObjectInterface->onCollisionSignal.trigger(thisComp->getOwner());
         }
         }
         }
         }*/
         else
         {
            mOwner->handleCollision(colCheck, velocity);
         }
      }
   }
}

void SimplePlayerCollision::safeDelete()
{
   SAFE_DELETE(mPhysicsRep);
}