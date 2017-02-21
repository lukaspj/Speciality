using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalFeatureVectorStruct
   {
      public float deltaRot;
      public float deltaMovedX;
      public float deltaMovedY;
      public float velX;
      public float velY;

      public float damageProb;
      public float deltaDamageProb;
      public float distanceToObstacleLeft;
      public float distanceToObstacleRight;
      public float health;
      public float enemyHealth;

      public int tickCount;
      public int ticksSinceObservedEnemy;
      public int ticksSinceDamage;
      public int shootDelay;
   }

   public class FeatureVector
   {
      public float DeltaRot { get; set; }
      public float DeltaMovedX { get; set; }
      public float DeltaMovedY { get; set; }
      public float VelX { get; set; }
      public float VelY { get; set; }

      public float DamageProb { get; set; }
      public float DeltaDamageProb { get; set; }
      public float DistanceToObstacleLeft { get; set; }
      public float DistanceToObstacleRight { get; set; }
      public float Health { get; set; }
      public float EnemyHealth { get; set; }

      public int TickCount { get; set; }
      public int TicksSinceObservedEnemy { get; set; }
      public int TicksSinceDamage { get; set; }
      public int ShootDelay { get; set; }

      public FeatureVector(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 15) throw new ArgumentException("FeatureVector always takes exactly 15 parameters");
         int i = 0;
         DeltaRot = float.Parse(split[i++]);
         DeltaMovedX = float.Parse(split[i++]);
         DeltaMovedY = float.Parse(split[i++]);
         VelX = float.Parse(split[i++]);
         VelY = float.Parse(split[i++]);

         DamageProb = float.Parse(split[i++]);
         DeltaDamageProb = float.Parse(split[i++]);
         DistanceToObstacleLeft = float.Parse(split[i++]);
         DistanceToObstacleRight = float.Parse(split[i++]);
         Health = float.Parse(split[i++]);
         EnemyHealth = float.Parse(split[i++]);

         TickCount = int.Parse(split[i++]);
         TicksSinceObservedEnemy = int.Parse(split[i++]);
         TicksSinceDamage = int.Parse(split[i++]);
         ShootDelay = int.Parse(split[i++]);
      }
      
      public string ToString()
      {
         return $"{DeltaRot} {DeltaMovedX} {DeltaMovedY} {VelX} {VelY} " +
                $"{DamageProb} {DeltaDamageProb} {DistanceToObstacleLeft} {DistanceToObstacleRight}" +
                $" {Health} {EnemyHealth} {TickCount} {TicksSinceObservedEnemy} " +
                $"{TicksSinceDamage} {ShootDelay}";
      }
   }
}
