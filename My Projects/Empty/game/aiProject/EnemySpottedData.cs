using Torque3D.Engine.Util.Enums;
using Torque3D.Util;

namespace GameAI {
   internal class EnemySpottedData {
      private float distanceToObstacleLeftSinceEnemySeen;
      private float distanceToObstacleRightSinceEnemySeen;
      private float rotSinceEnemySeen;

      public enum EnemyFOVPos {
         Unknown, Left, Right
      }

      public EnemyFOVPos EnemyFOVPosition = EnemyFOVPos.Unknown;
      public EnemyFOVPos LastEnemyFOVPosition = EnemyFOVPos.Unknown;

      public enum EnemySpottedState
      {
         NoEnemySpotted,
         EnemyInFOV,
         EnemyNotInFOV,
         DeterminingEnemyPositionOfFOV
      }

      public EnemySpottedState State = EnemySpottedState.NoEnemySpotted;

      public void Update(FeatureVector vector) {
         if (State == EnemySpottedState.DeterminingEnemyPositionOfFOV) return;
         if (vector.TicksSinceObservedEnemy == 0) {
            distanceToObstacleLeftSinceEnemySeen = vector.DistanceToObstacleLeft;
            distanceToObstacleRightSinceEnemySeen = vector.DistanceToObstacleRight;
            rotSinceEnemySeen = 0.0f;
            State = EnemySpottedState.EnemyInFOV;
         }
         else {
            rotSinceEnemySeen += vector.DeltaRot;
            State = EnemySpottedState.EnemyNotInFOV;
         }
      }

      public PlayerAction DetermineEnemyPosition(FeatureVector vector) {
         if (State != EnemySpottedState.DeterminingEnemyPositionOfFOV) {
            State = EnemySpottedState.DeterminingEnemyPositionOfFOV;
            return PlayerAction.Prepare;
         }
         
         if (AIClass.sLastAction == PlayerAction.Prepare) {
            return PlayerAction.TurnLeft;
         }

         PlayerAction action;

         if (vector.DeltaDamageProb > 0) {
            EnemyFOVPosition = EnemyFOVPos.Left;
            action = PlayerAction.TurnLeft;
         } else {
            EnemyFOVPosition = EnemyFOVPos.Right;
            action = PlayerAction.TurnRight;
         }
         LastEnemyFOVPosition = EnemyFOVPosition;
         State = EnemySpottedState.EnemyInFOV;

         return action;
      }

      public void ResetFOVPosition() {
         EnemyFOVPosition = EnemyFOVPos.Unknown;
      }
   }
}