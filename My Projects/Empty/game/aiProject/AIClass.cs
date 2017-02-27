using System;
using Torque3D;
using Torque3D.Engine.Util.Enums;
using Torque3D.Util;

namespace GameAI {
   public class AIClass {
      public static PlayerAction sLastAction = PlayerAction.None;

      private static Random rand = new Random();

      private static EnemySpottedData enemySpotted = new EnemySpottedData();

      private static SimplePlayerData a;

      [ConsoleFunction]
      public static PlayerAction TestAI(FeatureVector vector) {
         PlayerAction action;

         enemySpotted.Update(vector);

         if (vector.TicksSinceObservedEnemy < 10) {
            action = ReactToEnemy(vector);
         }
         else if (vector.TicksSinceObservedEnemy < 100) {
            enemySpotted.ResetFOVPosition();
            action = SearchForEnemy(vector);
         } else if (vector.TicksSinceDamage < 180) {
            action = PlayerAction.TurnLeft;
         }
         else {
            action = Discover(vector);
         }

         sLastAction = action;
         return action;
      }

      private static PlayerAction Discover(FeatureVector vector) {
         PlayerAction action;

         if (vector.DistanceToObstacleLeft < 2.0f || vector.DistanceToObstacleRight < 2.0f) {
            if (sLastAction == PlayerAction.TurnRight
               || sLastAction == PlayerAction.TurnLeft) {
               action = sLastAction;
            } else {
               action = rand.NextDouble() > 0.5 ? PlayerAction.TurnRight : PlayerAction.TurnLeft;
            }
         }
         else {
            int dec = vector.TickCount / 32;
            Random tmpRandom = new Random(dec);
            double r = tmpRandom.NextDouble();
            if (r < 0.5) {
               action = PlayerAction.MoveForward;
            } else if(r < 0.75) {
               action = PlayerAction.TurnLeft;
            } else {
               action = PlayerAction.TurnRight;
            }
         }
         return action;
      }

      private static PlayerAction SearchForEnemy(FeatureVector vector) {
         return PlayerAction.MoveForward;
      }

      private static PlayerAction ReactToEnemy(FeatureVector vector) {
         PlayerAction action;
         
         if (vector.DamageProb > 0.80) {
            if (vector.ShootDelay == 0) {
               action = PlayerAction.Shoot;
            } else {
               action = Dodge(vector);
            }
         }
         else if (vector.TicksSinceObservedEnemy == 0 && enemySpotted.EnemyFOVPosition == EnemySpottedData.EnemyFOVPos.Unknown) {
            action = enemySpotted.DetermineEnemyPosition(vector);
         }
         else if (enemySpotted.LastEnemyFOVPosition == EnemySpottedData.EnemyFOVPos.Left) action = PlayerAction.TurnLeft;
         else action = PlayerAction.TurnRight;
         return action;
      }

      private static PlayerAction Dodge(FeatureVector vector) {
         return PlayerAction.Prepare;
      }
   }
}