using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;
using Torque3D.Engine;
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
            other.OnDamage(float.Parse(DataBlock.getFieldValue("damage")));
         }
      }

      public void OnDamage(float val)
      {
         float curenthealth = float.Parse(getFieldValue("currentHealth"));
         float newHealth = curenthealth - val;
         if (newHealth <= 0)
         {
            OnDeath();
         }
         setFieldValue("curentHealth", newHealth.ToString());
      }

      private void OnDeath()
      {
         delete();
      }
   }
}
