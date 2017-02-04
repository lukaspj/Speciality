using Torque3D;

namespace Game.Modules.ClientServer.Client
{
   class Client
   {
      public static void initClient()
      {
         string appName = Globals.GetString("appName");
         Global.echo("\n--------- Initializing " + appName + ": Client Scripts ---------");

         // Make sure this variable reflects the correct state.
         Globals.SetBool("Server.Server::Dedicated", false);

         // Game information used to query the master server
         Globals.SetString("Client::GameTypeQuery", appName);
         Globals.SetString("Client::MissionTypeQuery", "Any");
         
         Message.Init();
         GameConnectionToServer.Init();
         LevelDownload.Init();
         LevelLoad.Init();

         //load prefs
         string prefPath = Core.HelperFunctions.getPrefpath();
         if (Global.isFile(prefPath + "/clientPrefs.cs"))
            Global.exec(prefPath + "/clientPrefs.cs");
         else
            Global.exec("data/defaults.cs");

         Core.HelperFunctions.loadMaterials();

         // Copy saved script prefs into C++ code.
         Global.setDefaultFov(Globals.GetFloat("pref::Player::defaultFov"));
         Global.setZoomSpeed(Globals.GetInt("pref::Player::zoomSpeed"));
      }
   }
}
