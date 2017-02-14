using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Server
{
   class LevelLoad
   {
      //-----------------------------------------------------------------------------
      // Mission Loading
      // The server portion of the client/server mission loading process
      //-----------------------------------------------------------------------------
      //-----------------------------------------------------------------------------
      // Server mission loading
      //-----------------------------------------------------------------------------
      // On every mission load except the first, there is a pause after
      // the initial mission info is downloaded to the client.

      public static void Init()
      {
         Globals.SetInt("MissionLoadPause", 5000);
      }

      //-----------------------------------------------------------------------------
      //This is the first call made by the server to kick the loading process off
      [ConsoleFunction]
      public static void loadMission(string missionName, bool isFirstMission)
      {
         endMission();
         Global.echo("*** LOADING MISSION: " + missionName);
         Global.echo("*** Stage 1 load");

         // increment the mission sequence (used for ghost sequencing)
         Globals.Increment("missionSequence");
         Globals.SetBool("missionRunning", false);
         Globals.SetString("Server::MissionFile", missionName);
         Globals.SetString("Server::LoadFailMsg", "");

         // Extract mission info from the mission file,
         // including the display name and stuff to send
         // to the client.
         LevelInfo.buildLoadInfo(missionName);

         SimGroup ClientGroup = Sim.FindObject<SimGroup>("ClientGroup");

         // Download mission info to the clients
         int count = ClientGroup.getCount();
         for (uint cl = 0; cl < count; cl++)
         {
            GameConnectionToClient client = ClientGroup.getObject(cl).As<GameConnectionToClient>();

            if (!client.isAIControlled())
            {
               LevelInfo.sendLoadInfoToClient(client);
            }
         }

         // Now that we've sent the LevelInfo to the clients
         // clear it so that it won't conflict with the actual
         // LevelInfo loaded in the level
         LevelInfo.clearLoadInfo();

         // if this isn't the first mission, allow some time for the server
         // to transmit information to the clients:
         if (isFirstMission || Globals.GetString("Server::ServerType").Equals("SinglePlayer"))
         {
            loadMissionStage2();
         }
         else
         {
            Global.schedule(Globals.GetString("MissionLoadPause"), "ServerGroup", "loadMissionStage2");
         };
      }

      //-----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void loadMissionStage2()
      {
         Global.echo("*** Stage 2 load");

         // Create the mission group off the ServerGroup
         Globals.SetString("instantGroup", "ServerGroup");

         // Make sure the mission exists
         string file = Globals.GetString("Server::MissionFile");

         if (!Global.isFile(file))
         {
            Globals.SetString("Server::LoadFailMsg", "Could not find mission \"" + file + "\"");
         }
         else
         {
            // Calculate the mission CRC.  The CRC is used by the clients
            // to caching mission lighting.
            Globals.SetInt("missionCRC", Global.getFileCRC(file));

            // Exec the mission.  The MissionGroup (loaded components) is added to the ServerGroup
            Global.exec(file);

            if (!Global.isObject("MissionGroup"))
            {
               Globals.SetString("Server::LoadFailMsg", "No 'MissionGroup' found in mission \"" + file + "\".");
            }
         }

         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         if (Globals.GetString("Server::LoadFailMsg") != "" )
         {
            // Inform clients that are already connected
            for (uint clientIndex = 0; clientIndex < ClientGroup.getCount(); clientIndex++)
               Message.messageClient(ClientGroup.getObject(clientIndex).As<GameConnectionToClient>(), "MsgLoadFailed".Tag(), Globals.GetString("Server::LoadFailMsg"));
            return;
         }

         Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");

         // Set mission name.
         if (Global.isObject("TheLevelInfo"))
            Globals.SetString("Server::MissionName", TheLevelInfo.getFieldValue("levelName"));

         // Mission cleanup group.  This is where run time components will reside.  The MissionCleanup
         // group will be added to the ServerGroup.
         SimGroup MissionCleanup = new SimGroup("MissionCleanup", true);

         // Make the MissionCleanup group the place where all new objects will automatically be added.
         Globals.SetInt("instantGroup", MissionCleanup.getId());

         // Construct MOD paths
         Global.pathOnMissionLoadDone();

         // Mission loading done...
         Global.echo("*** Mission loaded");

         // Start all the clients in the mission
         Globals.SetBool("missionRunning", true);
         for (uint clientIndex = 0; clientIndex < ClientGroup.getCount(); clientIndex++)
            ClientGroup.getObject(clientIndex).As<GameConnectionToClient>().loadMission();

         // Go ahead and launch the game
         //todo onMissionStart
         TheLevelInfo.call("onMissionStart");
      }

      [ConsoleFunction]
      public static void endMission()
      {
         if (!Global.isObject("MissionGroup"))
            return;

         Global.echo("*** ENDING MISSION");

         Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");

         // Inform the game code we're done.
         //todo onMissionEnded
         TheLevelInfo.call("onMissionEnded");

         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         // Inform the clients
         for (uint clientIndex = 0; clientIndex < ClientGroup.getCount(); clientIndex++)
         {
            // clear ghosts and paths from all clients
            GameConnectionToClient cl = ClientGroup.getObject(clientIndex).As<GameConnectionToClient>();
            cl.endMission();
            cl.resetGhosting();
            cl.clearPaths();
         }

         SimGroup MissionGroup = Sim.FindObject<SimGroup>("MissionGroup");
         SimGroup MissionCleanup = Sim.FindObject<SimGroup>("MissionCleanup");
         
         // Delete everything
         MissionGroup.delete();
         MissionCleanup.delete();

         Global.clearServerPaths();
      }

      [ConsoleFunction]
      public static void resetMission()
      {
         Global.echo("*** MISSION RESET");

         SimGroup PlayersGroup = Sim.FindObject<SimGroup>("Players");
         PlayersGroup.delete();
         SimGroup MissionCleanup = Sim.FindObject<SimGroup>("MissionCleanup");

         // Remove any temporary mission objects
         MissionCleanup.delete();
         Globals.SetString("instantGroup", "ServerGroup");
         
         MissionCleanup = new SimGroup("MissionCleanup", true);
         Globals.SetString("instantGroup", "MissionCleanup");

         Global.clearServerPaths();
         //
         Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");
         //todo onMissionReset
         TheLevelInfo.call("onMissionReset");
      }
   }
}
