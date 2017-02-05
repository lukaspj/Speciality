using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D.Engine;
using Torque3D;
using Torque3D.Util;
using Game.Modules.ClientServer.Server;


namespace Game.Modules.SpectatorGameplay.scripts.server
{
   class GamePlayer : Player
   {
      private int corpseTimeoutValue = 40 * 100;
      
      public GamePlayer(bool bRegister) : base(bRegister)
      {

      }

      public void onAdd(Player obj)
      {
         // Vehicle timeout
         obj.setFieldValue("mountVehicle", "true");

         // Default dynamic armor stats
         obj.setRechargeRate(float.Parse(obj.getFieldValue("rechargeRate")));
         obj.setRepairRate(0);

      }

      public void onRemove(Player obj)
      {
         int clientid = obj.getControllingClient();
         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)clientid);
         // TODO i guess this is now how to do it :S
         if (obj.Name == client.getFieldValue("player"))
         {
            client.setFieldValue("player", "0");
         }
      }

      public void onCollision(Player obj, GameBase col)
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

         if(col.getType() == TypeMask)
      }

   }
}
