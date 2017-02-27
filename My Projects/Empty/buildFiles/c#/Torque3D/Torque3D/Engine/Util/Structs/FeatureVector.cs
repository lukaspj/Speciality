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
      /// <summary>
      /// Difference in Rotation of the player since last frame
      /// </summary>
      public float DeltaRot { get; set; }
      /// <summary>
      /// Difference in movement in the X direction since last tick
      /// </summary>
      public float DeltaMovedX { get; set; }
      /// <summary>
      /// Difference in movement in the Y direction since last tick
      /// </summary>
      public float DeltaMovedY { get; set; }
      /// <summary>
      /// The current velocity in the X direction
      /// </summary>
      public float VelX { get; set; }
      /// <summary>
      /// The current velocity in the Y direction
      /// </summary>
      public float VelY { get; set; }

      /// <summary>
      /// The propability that you damage a player with a Shoot action
      /// </summary>
      public float DamageProb { get; set; }
      public float DeltaDamageProb { get; set; }
      ///<summary>
      /// Distance to nearest object in front of AI Player's left side
      /// </summary>
      public float DistanceToObstacleLeft { get; set; }
      ///<summary>
      /// Distance to nearest object in front of AI Player's right side
      /// </summary>
      public float DistanceToObstacleRight { get; set; }
      /// <summary>
      /// The AI Players current Health
      /// </summary>
      public float Health { get; set; }
      /// <summary>
      /// The current health of the enemy
      /// </summary>
      public float EnemyHealth { get; set; }

      /// <summary>
      /// The ammount of thicks since game start
      /// </summary>
      public int TickCount { get; set; }
      /// <summary>
      /// Ticks since the AI player observed an Enemy
      /// </summary>
      /// <remarks>
      /// If no players has been observed then this field is <c>int.MaxValue</c>
      /// </remarks>
      public int TicksSinceObservedEnemy { get; set; }
      /// <summary>
      /// Ticks since the AI player took damage
      /// </summary>
      public int TicksSinceDamage { get; set; }
      /// <summary>
      /// Delay in ticks untill the AI Player is able to Shoot again
      /// </summary>
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
