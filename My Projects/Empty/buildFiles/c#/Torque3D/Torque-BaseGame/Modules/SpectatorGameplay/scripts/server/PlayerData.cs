using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D.Engine;
using Torque3D;
using Torque3D.Util;
using Game.Modules.ClientServer.Server;
using tPlayer = Torque3D.Player;
using tPlayerData = Torque3D.PlayerData;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class PlayerData : tPlayerData
   {
      private int corpseTimeoutValue = 40 * 100;
      

      public void onAdd(tPlayer obj)
      {
         Console.WriteLine("Hello World");
      }

      public void onRemove(tPlayer obj)
      {
         int clientid = obj.getControllingClient();
         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)clientid);
         // TODO i guess this is now how to do it :S
         if (obj.Name == client.getFieldValue("player"))
         {
            client.setFieldValue("player", "0");
         }
      }

      public void onCollision(tPlayer obj, SceneObject col, VectorF vec, float len)
      {
         if(!Global.isObject(col.Name) || obj.getState() == "Dead")
         {
            return;
         }

         if(col.getClassName() == "Item")
         {
            //TODO is this how to do it ???
            obj.call("pickup", col.Name);
            return;
         }
         if(col.getClassName() == "StaticShape") {
            obj.setVelocity(new Point3F(0, 0, 0));
         }
         
      }

   }
}
