#ifndef _SIMPLEPLAYERCOLLISION_H_
#define _SIMPLEPLAYERCOLLISION_H_

#include "T3D/physics/physicsBody.h"
#include "collision/collision.h"
#include "collision/boxConvex.h"

struct CollisionWorkingList;
class SimplePlayer;

struct ContactInfo
{
   bool contacted, move;
   SceneObject *contactObject;
   VectorF  idealContactNormal;
   VectorF  contactNormal;
   Point3F  contactPoint;
   F32	   contactTime;
   S32	   contactTimer;
   BaseMatInstance *contactMaterial;

   void clear()
   {
      contacted = move = false;
      contactObject = NULL;
      contactNormal.set(0, 0, 0);
      contactTime = 0.f;
      contactTimer = 0;
      idealContactNormal.set(0, 0, 1);
      contactMaterial = NULL;
   }

   ContactInfo() { clear(); }

};

class SimplePlayerCollision {
public:
   SimplePlayer *mOwner;

   SimplePlayerCollision();

   void prepCollision(SimplePlayer* owner);
   void update();
   bool checkCollisions(const F32 travelTime, Point3F *velocity, Point3F start);


   CollisionList& getCollisionList() { return mCollisionList; }
   void safeDelete();
   ContactInfo getContactInfo() { return mContactInfo; };

private:
   void updateWorkingCollisionSet(const U32 mask);
   void _updatePhysics();
   bool checkEarlyOut(Point3F start, VectorF velocity, F32 time, Box3F objectBox, Point3F objectScale, Box3F collisionBox, U32 collisionMask, CollisionWorkingList& colWorkingList);
   bool updateCollisions(const F32 travelTime, Point3F vector, Point3F velocity);
   void handleCollisionList(CollisionList &collisionList, VectorF velocity);

   Point3F mColliderScale;
   PhysicsBody *mPhysicsRep;

   Convex *mConvexList;
   Box3F mWorkingQueryBox;
   CollisionList mCollisionList;
   ContactInfo mContactInfo;
};

#endif // _SIMPLEPLAYERCOLLISION_H_
