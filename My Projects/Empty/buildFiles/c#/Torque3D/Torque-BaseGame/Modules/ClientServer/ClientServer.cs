using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer
{
   [ConsoleClass]
   class ClientServer : SimSet
   {
      // The general flow of a gane - server's creation, loading and hosting clients, and then destruction is as follows:

      // First, a client will always create a server in the event that they want to host a single player
      // game. Torque3D treats even single player connections as a soft multiplayer game, with some stuff
      // in the networking short-circuited to sidestep around lag and packet transmission times.

      // initServer() is called, loading the default server scripts.
      // After that, if this is a dedicated server session, initDedicated() is called, otherwise initClient is called
      // to prep a playable client session.

      // When a local game is started - a listen server - via calling StartGame() a server is created and then the client is
      // connected to it via createAndConnectToLocalServer().

      public void create()
      {
         Global.echo("\n--------- Initializing Directory: scripts ---------");
         //todo exec client.cs
         //Global.exec("data/clientServer/scripts/client/client.cs");
         //todo exec server.cs
         //Global.exec("data/clientServer/scripts/server/server.cs");

         Globals.SetString("Game::MissionGroup", "MissionGroup");

         Server.Server.initServer();

         // todo DatablockFilesList
         new ArrayObject("DatablockFilesList", true);

         // Start up in either client or dedicated server mode
         if (Globals.GetBool("Server::Dedicated"))
         {
            Server.Server.initDedicated();
         }
         else
         {
            Client.Client.initClient();
         }
      }

      public void destroy()
      {
         // Ensure that we are disconnected and/or the server is destroyed.
         // This prevents crashes due to the SceneGraph being deleted before
         // the objects it contains.
         if (Globals.GetBool("Server::Dedicated"))
         {
            Server.Server.destroyServer();
         }
         else
         {
            Client.GameConnectionToServer.disconnect();
         }

         // Destroy the physics plugin.
         Global.physicsDestroy();

         Core.Audio.sfxShutdown();

         Global.echo("Exporting client prefs");
         string prefPath = Core.HelperFunctions.getPrefpath();
         Global.export("$pref::*", prefPath + "/clientPrefs.cs", false);

         Global.echo("Exporting server prefs");
         Global.export("$pref::Server::**", prefPath + "/serverPrefs.cs", false);
         //todo BanList::Export
         Global.eval($"BanList::Export({prefPath}/banlist.cs");
      }

      //-----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void StartGame(string mission=null, string hostingType=null)
      {
         if (string.IsNullOrEmpty(mission))
         {
            GuiTextListCtrl CL_levelList = Sim.FindObject<GuiTextListCtrl>("CL_levelList");
            int id = CL_levelList.getSelectedId();
            mission = Global.getField(CL_levelList.getRowTextById(id), 1);
            // Alternatively:
            //error("Cannot start a level with no level selected!");
         }

         string serverType = hostingType;
         if (string.IsNullOrEmpty(hostingType))
         {
            if (Globals.GetBool("pref::HostMultiPlayer"))
            {
               serverType = "MultiPlayer";
            }
            else
            {
               serverType = "SinglePlayer";
            }
         }

         // Show the loading screen immediately.
         if (Global.isObject("LoadingGui"))
         {
            Core.Canvas.GameCanvas.setContent(Sim.FindObject<GuiControl>("LoadingGui"));
            GuiProgressBitmapCtrl LoadingProgress = Sim.FindObject<GuiProgressBitmapCtrl>("LoadingProgress");
            GuiTextCtrl LoadingProgressTxt = Sim.FindObject<GuiTextCtrl>("LoadingProgressTxt");
            LoadingProgress.setValue("1");
            LoadingProgressTxt.setValue("LOADING MISSION FILE");
            Core.Canvas.GameCanvas.repaint();
         }

         Server.Server.createAndConnectToLocalServer(serverType, mission);
      }

      public static void JoinGame(uint serverIndex)
      {
         GuiProgressBitmapCtrl LoadingProgress = Sim.FindObject<GuiProgressBitmapCtrl>("LoadingProgress");
         GuiTextCtrl LoadingProgressTxt = Sim.FindObject<GuiTextCtrl>("LoadingProgressTxt");

         // The server info index is stored in the row along with the
         // rest of displayed info.
         if (Global.setServerInfo(serverIndex))
         {
            Core.Canvas.GameCanvas.setContent(Sim.FindObject<GuiControl>("LoadingGui"));
            LoadingProgress.setValue("1");
            LoadingProgressTxt.setValue("WAITING FOR SERVER");
            Core.Canvas.GameCanvas.repaint();

            GameConnection ServerConnection = new GameConnection("ServerConnection", true);
            ServerConnection.setConnectArgs(Globals.GetString("pref::Player::Name"));
            ServerConnection.setJoinPassword(Globals.GetString("Client::Password"));
            ServerConnection.connect(Globals.GetString("ServerInfo::Address"));
         }
      }
   }
}
