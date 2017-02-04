using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Client
{
   [ConsoleClass]
   class GameConnectionToServer : GameConnection
   {
      public GameConnectionToServer(string pName, bool pRegister = false) : base(pName, pRegister)
      {
      }

      public GameConnectionToServer(SimObject obj) : base(obj)
      {
      }

      public static void Init()
      {
         Message.addMessageCallback("MsgConnectionError".Tag(), "handleConnectionErrorMessage");
      }

      // Functions dealing with connecting to a server

      //----------------------------------------------------------------------------
      // GameConnection client callbacks
      //----------------------------------------------------------------------------

      /// <summary>
      /// Called on the new connection object after connect() succeeds.
      /// </summary>
      public void onConnectionAccepted()
      {
         // Startup the physX world on the client before any
         // datablocks and objects are ghosted over.
         Global.physicsInitWorld("client");
      }
      
      public void initialControlSet()
      {
         Global.echo("*** Initial Control Object");

         // The first control object has been set by the server
         // and we are now ready to go.

         // first check if the editor is active
         if (!Global.isToolBuild() || !Global.isMethod("Editor", "checkActiveLoadDone") || !GenericMarshal.StringToBool(Global.call("Editor::checkActiveLoadDone")))
         {
            GuiTSCtrl PlayGui = Sim.FindObject<GuiTSCtrl>("PlayGui");
            if (Core.Canvas.GameCanvas.getContent() != PlayGui.getId())
               Core.Canvas.GameCanvas.setContent(PlayGui);
         }
      }
      
      public void onControlObjectChange()
      {
         Global.echo("*** Control Object Changed");

         // Reset the current FOV to match the new object
         // and turn off any current zoom.
         Global.call("resetCurrentFOV");
         Global.call("turnOffZoom");
      }
      
      public void onConnectionError(string msg)
      {
         // General connection error, usually raised by ghosted objects
         // initialization problems, such as missing files.  We'll display
         // the server's connection error message.
         disconnectedCleanup();
         if (Global.isFunction("MesageBoxOK"))
         {
            //todo MessageBoxOK
            Global.call("MessageBoxOK", "DISCONNECT", Globals.GetString("ServerConnectionErrorMessage") + " (" + msg + ")");
         }
      }

      //-----------------------------------------------------------------------------
      // Server connection error
      //-----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void handleConnectionErrorMessage(string msgType, string msgString, string msgError)
      {
         // On connect the server transmits a message to display if there
         // are any problems with the connection.  Most connection errors
         // are game version differences, so hopefully the server message
         // will tell us where to get the latest version of the game.
         Globals.SetString("ServerConnectionErrorMessage", msgError);
      }

      //-----------------------------------------------------------------------------
      // Disconnect
      //-----------------------------------------------------------------------------

      [ConsoleFunction]
      public static void disconnect()
      {
         // We need to stop the client side simulation
         // else physics resources will not cleanup properly.
         Global.physicsStopSimulation("client");

         // Delete the connection if it's still there.
         if (Global.isObject("ServerConnection"))
            Sim.FindObject<GameConnectionToServer>("ServerConnection").delete();

         disconnectedCleanup();

         // Call destroyServer in case we're hosting
         Server.Server.destroyServer();
      }

      [ConsoleFunction]
      public static void disconnectedCleanup()
      {// End mission, if it's running.

         if (Globals.GetBool("Client::missionRunning"))
            LevelLoad.clientEndMission();
      
         // Disable mission lighting if it's going, this is here
         // in case we're disconnected while the mission is loading.
   
         Globals.SetBool("lightingMission", false);
         Globals.SetBool("sceneLighting::terminateLighting", true);

         // Back to the launch screen
         if (Global.isObject("MainMenuGui"))
            Core.Canvas.GameCanvas.setContent(Sim.FindObject<GuiControl>("MainMenuGui"));

         // Before we destroy the client physics world
         // make sure all ServerConnection objects are deleted.
         if (Global.isObject("ServerConnection"))
         {
            Sim.FindObject<GameConnectionToServer>("ServerConnection").deleteAllObjects();
         }

         // We can now delete the client physics simulation.
         Global.physicsDestroyWorld("client");
      }
   }
}
