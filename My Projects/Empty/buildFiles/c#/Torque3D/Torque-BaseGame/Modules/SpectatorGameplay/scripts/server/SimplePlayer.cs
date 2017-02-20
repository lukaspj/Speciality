using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

      public SimplePlayer(string name) : base(name)
      {
         
      }
      public SimplePlayer(SimObject pObj) : base(pObj)
      {
      }

      public SimplePlayer() : base()
      {
         
      }

      public void Shoot()
      {
         List<SimplePlayer> others = SimplePlayerData.searchForPlayers(this);
         if (others.Count == 0)
         {
            return;
         }
         SimplePlayer other = others[0];
         Random rand = new Random();
         
         double damagePropability = SimplePlayerData.GetDamagePropability(this, other);
         if (damagePropability >= rand.NextDouble())
         {
            bool kill = other.OnDamage(int.Parse(DataBlock.getFieldValue("damage")));
            if (kill)
            {
               int fieldValue = int.Parse( DataBlock.getFieldValue("killScore"));
               DataBlock.setFieldValue("score", fieldValue.ToString());
               int score = int.Parse(DataBlock.getFieldValue("score"));
               if (score >= int.Parse(DataBlock.getFieldValue("winningScore")))
               {
                  GameLogger.LogGameResult(this);

                  GuiTextCtrl scoreText = Sim.FindObject<GuiTextCtrl>(getName() + "score");
                  string text = scoreText.Text;
                  Regex reg = new Regex(@"\s");
                  int scoretxt = int.Parse(reg.Split(text)[1]) + 1;
                  scoreText.setText("Score: " + scoretxt);
                  DefaultGame.EndGame();
               }
            }
         }
      }
      /**
       * returns true if target is killed false otherwise
       */
      public bool OnDamage(int val)
      {
         ParticleEmitterNode node = new ParticleEmitterNode()
         {
            DataBlock = Sim.FindObject<ParticleEmitterNodeData>("HitNode"),
            Emitter = Sim.FindObject<ParticleEmitterData>("HitEmitter"),
            Position = Position
         };
         node.registerObject();
         node.schedule(200, "delete");

         float curenthealth = Health;
         float newHealth = curenthealth - val;

         GameLogger.LogDamageEvent(this, newHealth);

         GuiProgressCtrl progress = Sim.FindObject<GuiProgressCtrl>(getName() + "health");
         int maxHealth = int.Parse(DataBlock.getFieldValue("maxHealth"));
         progress.setValue((newHealth/maxHealth).ToString());
         if (newHealth <= 0)
         {
            OnDeath();
            return true;
         }
         Health = newHealth;

         return false;
      }

      private void OnDeath()
      {
         //Hidden = true;
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
