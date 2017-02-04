using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Modules.ClientServer.Server
{
   class Audio
   {
      public static void Init()
      {
      }

      public static void ServerPlay2D(SFXProfile profile)
      {
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         // Play the given sound profile on every client.
         // The sounds will be transmitted as an event, not attached to any object.
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            ClientGroup.getObject(i).As<GameConnectionToClient>().play2D(profile);
         }
      }

      public static void ServerPlay3D(SFXProfile profile, TransformF transform)
      {
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         // Play the given sound profile at the given position on every client
         // The sound will be transmitted as an event, not attached to any object.
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            ClientGroup.getObject(i).As<GameConnectionToClient>().play3D(profile, transform);
         }
      }
   }
}
