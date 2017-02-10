using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;
using tSimplePlayer = Torque3D.SimplePlayer;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class SimplePlayer : tSimplePlayer
   {
      public SimplePlayer(SimObject pObj) : base(pObj)
      {
      }

      public SimplePlayer() : base()
      {
         
      }

      public void Shoot(SimplePlayer other)
      {
         Random rand = new Random();
         
         double damagePropability = SimplePlayerData.GetDamagePropability(this, other);

         if (damagePropability >= rand.NextDouble())
         {
            bool kill = other.OnDamage(int.Parse(DataBlock.getFieldValue("damage")));
            if (kill)
            {
               DataBlock.setFieldValue("score", DataBlock.getFieldValue("killScore"));
               int score = int.Parse(getFieldValue("score"));
               if (score >= int.Parse(getFieldValue("winningScore")))
               {
                  Global.eval("resetMission()");
               }
            }
         }
      }
      /**
       * returns true if target is killed false otherwise
       */
      public bool OnDamage(int val)
      {
         float curenthealth = Health;
         float newHealth = curenthealth - val;
         if (newHealth <= 0)
         {
            Respawn();
            return true;
         }
         Health = newHealth;
         return false;
      }

      private void OnDeath()
      {
         Respawn();
      }

      private void Respawn()
      {
         Hidden = true;
         Timer timer = new Timer()
         {
            AutoReset = false,
            Interval = Double.Parse(getFieldValue("respawnTime"))
         };
         timer.Elapsed += (sender, args) =>
         {
            Position = new Point3F(getFieldValue("spawn"));
            Hidden = false;
         };
         timer.Enabled = true;

      }
   }
}
