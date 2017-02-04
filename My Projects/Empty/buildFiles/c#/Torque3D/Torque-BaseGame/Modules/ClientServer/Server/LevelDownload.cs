using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer.Server
{
   class LevelDownload
   {
      public static void Init()
      {
      }

      //-----------------------------------------------------------------------------
      // Mission Loading
      // The server portion of the client/server mission loading process
      //-----------------------------------------------------------------------------
      //--------------------------------------------------------------------------
      // Loading Phases:
      // Phase 1: Transmit Datablocks
      //          Transmit targets
      // Phase 2: Transmit Ghost Objects
      // Phase 3: Start Game
      //
      // The server invokes the client MissionStartPhase[1-3] function to request
      // permission to start each phase.  When a client is ready for a phase,
      // it responds with MissionStartPhase[1-3]Ack.


      //----------------------------------------------------------------------------
      // Phase 1 
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void serverCmdMissionStartPhase1Ack(string client, string seq)
      {
         GameConnectionToClient clientConnection = Sim.FindObject<GameConnectionToClient>(client);

         // Make sure to ignore calls from a previous mission load
         if (!seq.Equals(Globals.GetString("missionSequence")) || !Globals.GetBool("MissionRunning") || clientConnection.CurrentPhase != "0")
            return;
         
         clientConnection.CurrentPhase = "1";

         // Start with the CRC
         clientConnection.setMissionCRC(Globals.GetInt("missionCRC"));

         // Send over the datablocks...
         // OnDataBlocksDone will get called when have confirmation
         // that they've all been received.
         clientConnection.transmitDataBlocks(Globals.GetInt("missionSequence"));
      }


      //----------------------------------------------------------------------------
      // Phase 2
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void serverCmdMissionStartPhase2Ack(string client, string seq)
      {
         GameConnectionToClient clientConnection = Sim.FindObject<GameConnectionToClient>(client);

         // Make sure to ignore calls from a previous mission load
         if (!seq.Equals(Globals.GetString("missionSequence")) || !Globals.GetBool("MissionRunning") || clientConnection.CurrentPhase != "1.5")
            return;
         
         clientConnection.CurrentPhase = "2";

         // Update mod paths, this needs to get there before the objects.
         clientConnection.transmitPaths();

         // Start ghosting objects to the client
         clientConnection.activateGhosting();
      }


      //----------------------------------------------------------------------------
      // Phase 3
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void serverCmdMissionStartPhase3Ack(string client, string seq)
      {
         GameConnectionToClient clientConnection = Sim.FindObject<GameConnectionToClient>(client);

         // Make sure to ignore calls from a previous mission load
         if (!seq.Equals(Globals.GetString("missionSequence")) || !Globals.GetBool("MissionRunning") || clientConnection.CurrentPhase != "2")
            return;
         
         clientConnection.CurrentPhase = "3";

         // Server is ready to drop into the game

         Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");

         //Have any special game-play handling here
         TheLevelInfo.call("onClientEnterGame", client);
         
         clientConnection.startMission();
      }
   }
}
