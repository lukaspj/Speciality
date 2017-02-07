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
   class Observer : CameraData
   {
      public void onTrigger(Camera obj, int trigger, bool state)
      {
         // state = 0 means that a trigger key was released
         GameBaseData data = Sim.FindObjectById<GameBaseData>((uint)obj.getDataBlock());
         if (!state)
            return;

         // Default player triggers: 0=fire 1=altFire 2=jump

         GameConnectionToClient client = Sim.FindObjectById<GameConnectionToClient>((uint)obj.getControllingClient());
         switch (data.getFieldValue("mode")){
            case "Observer":
               // Do something interesting.
               break;
            case "Corpse":
               // Viewing dead corpse, so we probably want to respawn.
               client.call("spawnPlayer");
               // Set the camera back into observer mode, since in
               // debug mode we like to switch to it.
               setMode(obj, "Observer");
               break;
         }

      }

      private void setMode(Camera obj, string mode, params GameBase[] args)
      {
         switch (mode)
         {
            case "Observer":
               // Let the player fly around
               obj.setFieldValue("controlMode", "Overhead");
               break;
            case "Corpse":
               // Lock the camera down in orbit around the corpse,
               // which should be arg1
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
         // Default start mode
         setMode(cam, data.getFieldValue("mode"));

         return true;
      }
      
   }
}
