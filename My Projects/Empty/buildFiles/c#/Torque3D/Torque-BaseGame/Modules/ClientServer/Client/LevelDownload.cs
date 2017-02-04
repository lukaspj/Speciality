using System.CodeDom;
using Game.Core;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Client
{
   class LevelDownload
   {
      public static void Init()
      {
      }

      //-----------------------------------------------------------------------------
      // Mission Loading
      // The client portion of the client/server mission loading process
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
      public static void clientCmdMissionStartPhase1(string seq, string missionName)
      {
         // These need to come after the cls.
         Global.echo("*** New Mission: " + missionName);
         Global.echo("*** Phase 1: Download Datablocks & Targets");

         //Prep the postFX stuff
         // Load the post effect presets for this mission.
         string path = Global.filePath(missionName) + "/" + Global.fileBase(missionName) + Globals.GetString("PostFXManager::fileExtension");

         if (Core.HelperFunctions.isScriptFile(path))
         {
            //todo postFXManager::loadPresetHandler( % path);
            Global.eval($"postFXManager::loadPresetHandler({path});");
         }
         else
         {
            //todo PostFXManager::settingsApplyDefaultPreset();
            Global.eval("PostFXManager::settingsApplyDefaultPreset();");
         }

         onMissionDownloadPhase("LOADING DATABLOCKS");

         Global.commandToServer("MissionStartPhase1Ack".Tag(), seq);
      }

      [ConsoleFunction]
      public static void onDataBlockObjectReceived(string index, string total)
      {
         onMissionDownloadProgress(float.Parse(index) / float.Parse(total));
      }

      //----------------------------------------------------------------------------
      // Phase 2
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void clientCmdMissionStartPhase2(string seq, string missionName)
      {
         onPhaseComplete();
         Global.echo("*** Phase 2: Download Ghost Objects");

         onMissionDownloadPhase("LOADING OBJECTS");

         Global.commandToServer("MissionStartPhase2Ack".Tag(), seq);
      }

      [ConsoleFunction]
      public static void onGhostAlwaysStarted(string ghostCount)
      {
         Globals.SetInt("ghostCount", int.Parse(ghostCount));
         Globals.SetInt("ghostsRecvd", 0);
      }

      [ConsoleFunction]
      public static void onGhostAlwaysObjectReceived()
      {
         Globals.Increment("ghostsRecvd");
         onMissionDownloadProgress((float)Globals.GetInt("ghostsRecvd")/Globals.GetInt("ghostCount"));
      }

      //----------------------------------------------------------------------------
      // Phase 3
      //----------------------------------------------------------------------------
      [ConsoleFunction]
      public static void clientCmdMissionStartPhase3(string seq, string missionName)
      {
         onPhaseComplete();
         Global.StartClientReplication();
         Global.StartFoliageReplication();

         // Load the static mission decals.
         if (Global.isFile(missionName + ".decals"))
            Global.decalManagerLoad(missionName + ".decals");

         Global.echo("*** Phase 3: Mission Lighting");
         Globals.SetString("MSeq", seq);
         Globals.SetString("Client::MissionFile", missionName);

         // Need to light the mission before we are ready.
         // The sceneLightingComplete function will complete the handshake 
         // once the scene lighting is done.
         if (Global.lightScene("sceneLightingComplete", ""))
         {
            Global.echo("Lighting mission....");
            Global.schedule("1", "0", "updateLightingProgress");

            onMissionDownloadPhase("LIGHTING MISSION");
      
            Globals.SetBool("lightingMission", true);
         }
      }

      public static void updateLightingProgress()
      {
         onMissionDownloadProgress(Globals.GetFloat("SceneLighting::lightingProgress"));
         if (Globals.GetBool("lightingMission"))
            Globals.SetInt("lightingProgressThread", Global.schedule("1", "0", "updateLightingProgress"));
      }

      [ConsoleFunction]
      public static void sceneLightingComplete()
      {
         Global.echo("Mission lighting done");
         Globals.SetBool("lightingMission", false);

         onPhaseComplete("STARTING MISSION");

         // The is also the end of the mission load cycle.
         Global.commandToServer("MissionStartPhase3Ack".Tag(), Globals.GetString("MSeq"));
      }

      //----------------------------------------------------------------------------
      // Helper functions
      //----------------------------------------------------------------------------

      public static void connect(string server)
      {
         GameConnectionToServer conn = new GameConnectionToServer("ServerConnection", true);
         SimGroup RootGroup = Sim.FindObject<SimGroup>("RootGroup");
         RootGroup.add(conn);
         conn.setConnectArgs(Globals.GetString("pref::Player::Name"));
         conn.setJoinPassword(Globals.GetString("Client::Password"));
         conn.connect(server);
      }

      public static void onMissionDownloadPhase(string phase)
      {
         if (!Global.isObject("LoadingProgress"))
            return;

         GuiProgressBitmapCtrl LoadingProgress = Sim.FindObject<GuiProgressBitmapCtrl>("LoadingProgress");
         GuiTextCtrl LoadingProgressTxt = Sim.FindObject<GuiTextCtrl>("LoadingProgressTxt");
         LoadingProgress.setValue("0");
         LoadingProgressTxt.setValue(phase);
         Canvas.GameCanvas.repaint();
      }

      public static void onMissionDownloadProgress(float progress)
      {
         if (!Global.isObject("LoadingProgress"))
            return;

         GuiProgressBitmapCtrl LoadingProgress = Sim.FindObject<GuiProgressBitmapCtrl>("LoadingProgress");
         LoadingProgress.setValue(progress.ToString());
         Canvas.GameCanvas.repaint(33);
      }

      public static void onPhaseComplete(string text = null)
      {
         if (!Global.isObject("LoadingProgress"))
            return;

         GuiTextCtrl LoadingProgressTxt = Sim.FindObject<GuiTextCtrl>("LoadingProgressTxt");
         if (!string.IsNullOrEmpty(text))
            LoadingProgressTxt.setValue(text);


         GuiProgressBitmapCtrl LoadingProgress = Sim.FindObject<GuiProgressBitmapCtrl>("LoadingProgress");
         LoadingProgress.setValue("1");
         Canvas.GameCanvas.repaint();
      }
   }
}
