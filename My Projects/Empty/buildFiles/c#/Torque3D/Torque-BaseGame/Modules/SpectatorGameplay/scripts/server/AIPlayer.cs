using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;
using Torque3D.Engine.Util.Enums;
using Torque3D.Util;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass()]
   class AIPlayer : SimObject
   {
      [ConsoleFunction]
      public static PlayerAction SPThink0(FeatureVector vector)
      {
         Random rand = new Random();
         if (vector.DistanceToObstacleLeft < 5 || vector.DistanceToObstacleRight < 5)
         {
            return PlayerAction.TurnRight;
         }
         if (vector.TicksSinceObservedEnemy < 10)
         {
            if (vector.DamageProb > 0.80 && vector.ShootDelay == 0)
            {
               return PlayerAction.Shoot;
            }
            if (vector.DeltaDamageProb > 0)
            {
               if (vector.DeltaRot < 0)
               {
                  return PlayerAction.TurnRight;
               }
               return PlayerAction.TurnLeft;
            }
            if (vector.DeltaRot > 0)
            {
               return PlayerAction.TurnRight;
            }
            if (vector.DeltaRot < 0)
            {
               return PlayerAction.TurnLeft;
            }
            if (rand.NextDouble() <= 0.5)
            {
               return PlayerAction.TurnLeft;
            }
            return PlayerAction.TurnRight;
         }
         return PlayerAction.MoveForward;
      }
   }
}
