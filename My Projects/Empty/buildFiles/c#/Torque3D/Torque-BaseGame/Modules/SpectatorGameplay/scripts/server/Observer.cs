using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;
using Torque3D.Util;
using Torque3D.Engine;
using Game.Modules.ClientServer.Server;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   class Observer : Camera
   {
      
      public Observer(bool pRegister) : base(pRegister)
      {
      }

      [ConsoleFunction]
      public void onTrigger(Camera obj, int trigger, bool state)
      {
         // state = 0 means that a trigger key was released
         GameBaseData data = Sim.FindObjectById<GameBaseData>((uint)obj.getDataBlock());
         if (!state)
            return;
         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)obj.getControllingClient());
         
         switch (data.getFieldValue("mode")){
            case "Observer":
               break;
            case "Corpse":
               client.call("spawnPlayer");
               setMode(obj, "Observer");
               break;
         }

      }

      [ConsoleFunction]
      private void setMode(Camera obj, string mode, params GameBase[] args)
      {
         switch (mode)
         {
            case "Observer":
               obj.setFlyMode();
               break;
            case "Corpse":
               TransformF trans = args[1].getTransform();
               obj.setOrbitMode(args[1], trans, 0.5f, 4.5f, 4.5f);
               break;

         }
         GameBaseData data = Sim.FindObjectById<GameBaseData>((uint)obj.getDataBlock());
         data.setFieldValue("mode", mode);

      }

      public bool onAdd(GameBase obj)
      {

         GameBaseData data = Sim.FindObjectById<GameBaseData>((uint)obj.getDataBlock());
         Camera cam = obj.As<Camera>();
         setMode(cam, data.getFieldValue("mode"));

         return true;
      }
      
   }
}
