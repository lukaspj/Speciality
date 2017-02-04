using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer.Client
{
   class LevelLoad
   {
      public static void Init()
      {
         // Whether the local client is currently running a mission.
         Globals.SetBool("Client::missionRunning", false);

         // Sequence number for currently running mission.
         Globals.SetInt("Client::missionSeq", -1);
      }

      // Called when mission is started.
      [ConsoleFunction]
      public static void clientStartMission()
      {
         // The client recieves a mission start right before
         // being dropped into the game.
         Global.physicsStartSimulation("client");

         // Start game audio effects channels.
         Core.Audio.AudioChannelEffects.play();

         // Create client mission cleanup group.
         new SimGroup("ClientMissionCleanup", true);

         // Done.
         Globals.SetBool("Client::missionRunning", true);
      }

      // Called when mission is ended (either through disconnect or
      // mission end client command).
      [ConsoleFunction]
      public static void clientEndMission()
      {
         // Stop physics simulation on client.
         Global.physicsStopSimulation("client");

         // Stop game audio effects channels.
         Core.Audio.AudioChannelEffects.stop();

         // Delete all the decals.
         Global.decalManagerClear();

         // Delete client mission cleanup group. 
         if (Global.isObject("ClientMissionCleanup"))
            Sim.FindObject<SimGroup>("ClientMissionCleanup").delete();

         Global.clearClientPaths();

         // Done.
         Globals.SetBool("Client::missionRunning", true);
      }

      //----------------------------------------------------------------------------
      // Mission start / end events sent from the server
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void clientCmdMissionStart(string seq)
      {
         clientStartMission();
         Globals.SetString("Client::missionSeq", seq);
      }

      [ConsoleFunction]
      public static void clientCmdMissionEnd(string seq)
      {
         if (Globals.GetBool("Client::missionRunning") && Globals.GetString("Client::missionSeq").Equals(seq))
         {
            clientEndMission();
            Globals.SetString("Client::missionSeq", "-1");
         }
      }
   }
}
