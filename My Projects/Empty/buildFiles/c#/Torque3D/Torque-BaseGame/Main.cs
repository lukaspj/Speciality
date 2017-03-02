using System.Reflection;
using Game.Modules.ClientServer;
using Torque3D;
using Torque3D.Engine;
using Path = System.IO.Path;

namespace Game
{
   public class Main
   {
      [ScriptEntryPoint]
      public static void main()
      {
         // --- Boilerplate C#-specific setup. Normally Torque uses the main.cs file to set these variables, here we have to do it ourselves.
         string CSDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace('\\', '/');
         Global.setMainDotCsDir(CSDir);
         Global.setCurrentDirectory(CSDir);
         // ---

         // Enable console logging, which creates the file console.log each time you run
         // the engine.
         Global.setLogMode(6);

         // Display a splash window immediately to improve app responsiveness before
         // engine is initialized and main window created
         Global.displaySplashWindow("splash.bmp");

         // Disable script trace.
         Global.trace(false);

         // Set the name of our application
         Globals.SetString("appName", "BaseGame");

         //-----------------------------------------------------------------------------
         // Load up scripts to initialise subsystems.
         Core.Main.Init();

         // Parse the command line arguments
         Global.echo("\n--------- Parsing Arguments ---------");
         Core.ParseArgs.Run();

         // The canvas needs to be initialized before any gui scripts are run since
         // some of the controls assume that the canvas exists at load time.
         Core.Canvas.createCanvas(Globals.GetString("appName"));

         //-----------------------------------------------------------------------------
         // Load console.
         Core.Console.Main.Init();

         // Init the physics plugin.
         Global.physicsInit();

         // Init the sound system.
         Core.Audio.sfxStartup();

         // Set up networking.
         Global.setNetPort(0);

         // Start processing file change events.
         Global.startFileChangeNotifications();

         // If we have editors, initialize them here
         if (Global.isFile("tools/main.cs") && !Globals.GetBool("isDedicated"))
            Global.exec("tools/main.cs");

         ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
         ModuleDatabase.setModuleExtension("module");
         ModuleDatabase.scanModules("data", false);
         ModuleDatabase.loadGroup("Game");
         
         if (!Globals.GetBool("isDedicated"))
         {
            // Start rendering and stuff.
            Core.RenderManager.initRenderManager();
            Core.Lighting.initLightingSystems("Advanced Lighting");

            // Load prefs
            string prefPath = Global.getPrefsPath();
            if (Global.isFile(prefPath + "/clientPrefs.cs"))
               Global.exec(prefPath + "/clientPrefs.cs");
            else
               Global.exec("data/defaults.cs");

            Core.Canvas.configureCanvas();

            // Autodetect settings if it's our first time
            if (Globals.GetBool("pref::Video::autoDetect"))
            {
               //todo GraphicsMenu.Autodetect()
               Global.eval("GraphicsMenu.AutoDetect");
            }

            ClientServer.StartGame("data/spectatorGameplay/levels/Empty_Room.mis");

            Global.closeSplashWindow();

            // As we know at this point that the initial load is complete,
            // we can hide any splash screen we have, and show the canvas.
            // This keeps things looking nice, instead of having a blank window
            Core.Canvas.GameCanvas.showWindow();
         }
         else
         {
            Global.closeSplashWindow();
         }
      }
      
      //-----------------------------------------------------------------------------
      // Called when the engine is shutting down.
      [ConsoleFunction]
      public static void onExit()
      {
         // Stop file change events.
         Global.stopFileChangeNotifications();

         ModuleManager ModuleDatabase = Sim.FindObject<ModuleManager>("ModuleDatabase");
         ModuleDatabase.unloadExplicit("Game");
      }
   }
}