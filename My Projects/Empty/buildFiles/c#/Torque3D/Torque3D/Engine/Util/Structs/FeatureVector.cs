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
      public float distanceToObstacle;
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
      public float DistanceToObstacle { get; set; }
      public float Health { get; set; }
      public float EnemyHealth { get; set; }

      public int TickCount { get; set; }
      public int TicksSinceObservedEnemy { get; set; }
      public int TicksSinceDamage { get; set; }
      public int ShootDelay { get; set; }

      public FeatureVector(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 14) throw new ArgumentException("FeatureVector always takes exactly 14 parameters");
         DeltaRot = float.Parse(split[0]);
         DeltaMovedX = float.Parse(split[1]);
         DeltaMovedY = float.Parse(split[2]);
         VelX = float.Parse(split[3]);
         VelY = float.Parse(split[4]);

         DamageProb = float.Parse(split[5]);
         DeltaDamageProb = float.Parse(split[6]);
         DistanceToObstacle = float.Parse(split[7]);
         Health = float.Parse(split[8]);
         EnemyHealth = float.Parse(split[9]);

         TickCount = int.Parse(split[10]);
         TicksSinceObservedEnemy = int.Parse(split[11]);
         TicksSinceDamage = int.Parse(split[12]);
         ShootDelay = int.Parse(split[13]);
      }
      
      public string ToString()
      {
         return $"{DeltaRot} {DeltaMovedX} {DeltaMovedY} {VelX} {VelY} " +
                $"{DamageProb} {DeltaDamageProb} {DistanceToObstacle} {Health} " +
                $"{EnemyHealth} {TickCount} {TicksSinceObservedEnemy} " +
                $"{TicksSinceDamage} {ShootDelay}";
      }
   }
}
