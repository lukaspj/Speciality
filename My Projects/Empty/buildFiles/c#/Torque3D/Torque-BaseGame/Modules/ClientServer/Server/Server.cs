using System.Collections.Generic;
using Game.Modules.ClientServer.Client;
using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer.Server
{
   class Server
   {
      [ConsoleFunction]
      public static void initServer()
      {
         Global.echo("\n--------- Initializing " + Globals.GetString("appName") + ": Server Scripts ---------");

         // Load prefs
         string prefPath = Core.HelperFunctions.getPrefpath();
         if (Global.isFile(prefPath + "/serverPrefs.cs"))
         {
            Global.exec(prefPath + "/serverPrefs.cs");
         }
         else
         {
            //todo exec server/defaults.cs
            Global.exec("data/clientServer/scripts/server/defaults.cs");
         }

         Audio.Init();
         Commands.Init();
         Message.Init();
         LevelDownload.Init();
         LevelLoad.Init();
         LevelInfo.Init();
         GameConnectionToClient.Init();

         // Server::Status is returned in the Game Info Query and represents the
         // current status of the server. This string sould be very short.
         Globals.SetString("Server::Status", "Unknown");

         // Turn on testing/debug script functions
         Globals.SetBool("Server::TestCheats", false);
         
         // Specify where the mission files are.
         Globals.SetString("Server::MissionFileSpec", "data/levels/*.mis");
      }

      //-----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void initDedicated()
      {
         Global.enableWinConsole(true);
         Global.echo("\n--------- Starting Dedicated Server ---------");

         // Make sure this variable reflects the correct state.
         Globals.SetBool("Server::Dedicated", true);

         // The server isn't started unless a mission has been specified.
         if (!string.IsNullOrEmpty(Globals.GetString("missionArg")))
         {
            createServer("MultiPlayer", Globals.GetString("missionArg"));
         }
         else
         {
            Global.echo("No mission specified (use -mission filename)");
         }
      }

      /// <summary>
      /// Attempt to find an open port to initialize the server with
      /// </summary>
      /// <param name="port"></param>
      [ConsoleFunction]
      public static void portInit(int port)
      {
         int failCount = 0;
         while (failCount < 10 && !Global.setNetPort(port))
         {
            Global.echo("Port init failed on port " + port + " trying next port.");
            port++;
            failCount++;
         }
      }

      /// <summary>
      /// Create a server of the given type, load the given level, and then
      /// create a local client connection to the server.
      /// </summary>
      /// <param name="serverType"></param>
      /// <param name="level"></param>
      /// <returns>true if succesful.</returns>
      [ConsoleFunction]
      public static bool createAndConnectToLocalServer(string serverType, string level)
      {
         if (!createServer(serverType, level))
            return false;

         GameConnectionToServer ServerConnection = new GameConnectionToServer("ServerConnection", true);
         SimGroup RootGroup = Sim.FindObject<SimGroup>("RootGroup");
         RootGroup.add(ServerConnection);

         ServerConnection.setConnectArgs(Globals.GetString("pref::Player::Name"));
         ServerConnection.setJoinPassword(Globals.GetString("Client::Password"));

         string result = ServerConnection.connectLocal();
         if (!string.IsNullOrEmpty(result))
         {
            ServerConnection.delete();
            destroyServer();

            return false;
         }

         return true;
      }

      /// <summary>
      /// Create a server with either a "SinglePlayer" or "MultiPlayer" type
      /// Specify the level to load on the server
      /// </summary>
      /// <param name="serverType"></param>
      /// <param name="level"></param>
      /// <returns></returns>
      [ConsoleFunction]
      public static bool createServer(string serverType, string level)
      {
         // Increase the server session number.  This is used to make sure we're
         // working with the server session we think we are.
         Globals.Increment("Server::Session");

         if (string.IsNullOrEmpty(level))
         {
            Global.error("createServer(): level name unspecified");
            return false;
         }

         // Make sure our level name is relative so that it can send
         // across the network correctly
         level = Global.makeRelativePath(level, Global.getWorkingDirectory());

         destroyServer();

         Globals.SetInt("missionSequence", 0);
         Globals.SetInt("Server::PlayerCount", 0);
         Globals.SetString("Server::ServerType", serverType);
         Globals.SetString("Server::LoadFailMsg", "");
         Globals.SetBool("Physics::isSinglePlayer", true);


         // Setup for multi-player, the network must have been
         // initialized before now.
         if (serverType.Equals("MultiPlayer"))
         {
            Globals.SetBool("Physics::isSinglePlayer", false);
            Global.echo("Starting multiplayer mode");

            // Make sure the network port is set to the correct pref.
            portInit(Globals.GetInt("Pref::Server::Port"));
            Global.allowConnections(true);

            if (!Globals.GetString("pref::Net::DisplayOnMaster").Equals("Never"))
            {
               Global.schedule("0", "0", Global.getTag("startHeartbeat"));
            }
         }

         // Let the game initialize some things now that the
         // the server has been created
         onServerCreated();
         
         LevelLoad.loadMission(level, true);
   
         Globals.SetBool("Game::running", true);

         return true;
      }

      [ConsoleFunction]
      public static void onServerCreated()
      {
         // Server::GameType is sent to the master server.
         // This variable should uniquely identify your game and/or mod.
         Globals.SetString("Server::GameType", Globals.GetString("appName"));

         // Server::MissionType sent to the master server.  Clients can
         // filter servers based on mission type.
         // $Server::MissionType = "Deathmatch";

         // GameStartTime is the sim time the game started. Used to calculated
         // game elapsed time.
         Globals.SetInt("Game::StartTime", 0);

         // Create the server physics world.
         Global.physicsInitWorld("server");

         Global.physicsStartSimulation("server");

         ArrayObject DatablockFilesList = Sim.FindObject<ArrayObject>("DatablockFilesList");
         List<string> datablockFiles = new List<string>();
         for (int i = 0; i < DatablockFilesList.count(); i++)
         {
            datablockFiles.Add(DatablockFilesList.getKey(i));
         }

         Core.HelperFunctions.loadDatablockFiles(datablockFiles, true);

         //todo DatablockFilesList
         //% cnt = DatablockFilesList.count();

         //loadDatablockFiles(DatablockFilesList, true);

         //% cnt = DatablockFilesList.count();

         // Keep track of when the game started
         Globals.SetString("Game::StartTime", "Sim::Time");
      }

      /// <summary>
      /// Shut down the server
      /// </summary>
      [ConsoleFunction]
      public static void destroyServer()
      {
         Globals.SetString("Server::ServerType", "");
         Globals.SetBool("Server::Running", false);

         Global.allowConnections(false);
         Global.stopHeartbeat();
         Globals.SetBool("missionRunning", false);

         // End any running levels and shut down the physics sim
         onServerDestroyed();

         Global.physicsDestroy();

         // Delete all the server objects
         if (Global.isObject("ServerGroup"))
            Sim.FindObject<SimGroup>("ServerGroup").delete();

         SimGroup ClientGroup = Sim.FindObject<SimGroup>("ClientGroup");

         // Delete all the connections:
         while (ClientGroup.getCount() > 0)
         {
            GameConnection client = ClientGroup.getObject(0).As<GameConnection>();
            client.delete();
         }

         Globals.SetString("Server::GuidList", "");

         // Delete all the data blocks...
         Global.deleteDataBlocks();

         // Save any server settings
         Global.echo("Exporting server prefs...");
         Global.export("$Pref::Server::*", "data/clientServer/scripts/server/prefs.cs", false);

         // Increase the server session number.  This is used to make sure we're
         // working with the server session we think we are.
         Globals.Increment("Server::Session");
      }

      [ConsoleFunction]
      public static void onServerDestroyed()
      {
         Global.physicsStopSimulation("server");

         if(!Global.isObject("MissionGroup")) return;

         Global.echo("*** ENDING MISSION");

         // Inform the game code we're done.
         Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");
         //todo onMissionEnded
         TheLevelInfo.call("onMissionEnded");

         SimGroup ClientGroup = Sim.FindObject<SimGroup>("ClientGroup");
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

      // Guid list maintenance functions
      [ConsoleFunction]
      public static void addToServerGuidList(string guid)
      {
         string guidList = Globals.GetString("Server::GuidList");
         int count = Global.getFieldCount(guidList);
         for (int i = 0; i < count; i++)
         {
            if (Global.getField(guidList, i).Equals(guid))
            {
               return;
            }
         }

         Globals.SetString("Server::GuidList", string.IsNullOrEmpty(guidList) ? guid : guidList + "\t" + guid);
      }

      [ConsoleFunction]
      public static void removeFromServerGuidList(string guid)
      {
         string guidList = Globals.GetString("Server::GuidList");
         int count = Global.getFieldCount(guidList);
         for (int i = 0; i < count; i++)
         {
            if (Global.getField(guidList, i).Equals(guid))
            {
               Globals.SetString("Server::GuidList", Global.removeField(guidList, i));
               return;
            }
         }

         Globals.SetString("Server::GuidList", string.IsNullOrEmpty(guidList) ? guid : guidList + "\t" + guid);
      }

      /// <summary>
      /// When the server is queried for information, the value of this function is
      /// returned as the status field of the query packet.  This information is
      /// accessible as the ServerInfo::State variable.
      /// </summary>
      /// <returns></returns>
      [ConsoleFunction]
      public static string onServerInfoQuery()
      {
         return "Doing OK";
      }
   }
}
