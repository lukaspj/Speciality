using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer.Server
{
   class Commands
   {
      public static void Init()
      {
      }

      //-----------------------------------------------------------------------------
      // Misc. server commands avialable to clients
      //-----------------------------------------------------------------------------

      //----------------------------------------------------------------------------
      // Debug commands
      //----------------------------------------------------------------------------
      public static void serverCmdNetSimulateLag(string client, string msDelay, string packetLossPercent)
      {
         GameConnectionToClient clientConnection = Sim.FindObject<GameConnectionToClient>(client);
         if (clientConnection.IsAdmin)
         {
            float pctLossPrct = float.Parse(packetLossPercent);
            int delay = int.Parse(msDelay);

            clientConnection.setSimulatedNetParams(pctLossPrct, delay);
         }
      }
   }
}
