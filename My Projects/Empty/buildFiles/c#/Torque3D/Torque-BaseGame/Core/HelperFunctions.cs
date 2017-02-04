using System;
using System.Collections.Generic;
using System.Diagnostics;
using Torque3D;
using Torque3D.Engine;

namespace Game.Core
{
   class HelperFunctions
   {
      /// <summary>
      ///    Check if a script file exists, compiled or not.
      /// </summary>
      /// <param name="path"></param>
      /// <returns></returns>
      [ConsoleFunction]
      public static bool isScriptFile(string path)
      {
         return Global.isFile("path" + ".dso") || Global.isFile(path);
      }

      /// <summary>
      /// </summary>
      [ConsoleFunction]
      public static void loadMaterials()
      {
         // Load any materials files for which we only have DSOs.

         for (string file = Global.findFirstFile("*/materials.cs.dso");
            !string.IsNullOrEmpty(file);
            file = Global.findNextFile("*/materials.cs.dso"))
         {
            // Only execute, if we don't have the source file.
            string csFileName = file.Substring(0, file.Length - 4);
            if (!Global.isFile(csFileName))
               Global.exec(csFileName);
         }

         // Load all source material files.

         for (string file = Global.findFirstFile("*/materials.cs");
            !string.IsNullOrEmpty(file);
            file = Global.findNextFile("*/materials.cs"))
         {
            Global.exec(file);
         }

         // Load all materials created by the material editor if
         // the folder exists
         if (Global.IsDirectory("materialEditor"))
         {
            for (string file = Global.findFirstFile("materialEditor/*.cs.dso");
               string.IsNullOrEmpty(file);
               file = Global.findNextFile("materialEditor/*.cs.dso"))
            {
               // Only execute, if we don't have the source file.
               string csFileName = file.Substring(0, file.Length - 4);
               if (!Global.isFile(csFileName))
                  Global.exec(csFileName);
            }

            for (string file = Global.findFirstFile("materialEditor/*.cs");
               string.IsNullOrEmpty(file);
               file = Global.findNextFile("materialEditor/*.cs"))
            {
               Global.exec(file);
            }
         }
      }

      public static void reloadMaterials()
      {
         Global.reloadTextures();
         loadMaterials();
         Global.reInitMaterials();
      }
      
      public static void loadDatablockFiles(List<string> datablockFiles, bool recurse)
      {
         if (recurse)
         {
            recursiveLoadDatablockFiles(datablockFiles, 9999);
            return;
         }
         
         foreach (string datablockFile in datablockFiles)
         {
            if(!Global.isFile(datablockFile + ".dso") && !Global.isFile(datablockFile))
               continue;

            Global.exec(datablockFile);
         }
      }

      private static void recursiveLoadDatablockFiles(List<string> datablockFiles, int previousErrors)
      {
         List<string> reloadDatablockFiles = new List<string>();

         // Keep track of the number of datablocks that 
         // failed during this pass
         int failedDatablocks = 0;

         // Try re-executing the list of datablock files.
         foreach (string datablockFile in datablockFiles)
         {
            if (!Global.isFile(datablockFile + ".dso") && !Global.isFile(datablockFile))
               continue;

            // Start counting copy constructor creation errors
            Globals.SetInt("Con::objectCopyFailures", 0);

            Global.exec(datablockFile);

            // if errors occured then store this file for re-exec later.
            if (Globals.GetInt("Con::objectCopyFailures") > 0)
            {
               reloadDatablockFiles.Add(datablockFile);
               failedDatablocks += Globals.GetInt("Con::objectCopyFailures");
            }
         }

         // Clear the object copy failure counter so that
         // we get console error messages again.
         Globals.SetInt("Con::objectCopyFailures", -1);

         // If we still have datablocks to retry.
         if (reloadDatablockFiles.Count > 0)
         {
            // If the datablock failures have not been reduced
            // from the last pass then we must have a real syntax
            // error and not just a bad dependancy.
            if(previousErrors > failedDatablocks)
               recursiveLoadDatablockFiles(reloadDatablockFiles, failedDatablocks);
            else
            {
               // Since we must have real syntax errors do one 
               // last normal exec to output error messages.
               loadDatablockFiles(reloadDatablockFiles, false);
            }
         }
      }

      [ConsoleFunction]
      public static string getPrefpath()
      {
         string temp = Global.getUserHomeDirectory();
         string prefpath = null;
         Global.echo(temp);
         if (!Global.IsDirectory(temp))
         {
            temp = Global.getUserDataDirectory();
            Global.echo(temp);
            if (!Global.IsDirectory(temp))
            {
               prefpath = "data";
            }
            else
            {
               // Put it in appdata/roaming
               prefpath = temp + "/" + Globals.GetString("appName") + "/preferences";
            }
         }
         else
         {
            // Put it in user/documents
            prefpath = temp + "/" + Globals.GetString("appName") + "/preferences";
         }
         Globals.SetString("prefpath", prefpath);
         return prefpath;
      }

      [ConsoleFunction]
      public static void updateTSShapeLoadProgress(string pProgress, string pMsg)
      {
         float progress = float.Parse(pProgress);
         //todo
         return;
         GuiProgressCtrl progressCtrl = null;
         GuiTextCtrl textCtrl = null;

         // Check if the loading GUI is visible and use that instead of the
         // separate import progress GUI if possible
         GuiControl LoadingGui = Sim.FindObject<GuiControl>("LoadingGui");
         if (Global.isObject("LoadingGui") && LoadingGui.isAwake())
         {
            // Save/Restor load progress at the start/end of the import process
            if (Math.Abs(progress) < 0.000001)
            {
               GuiProgressCtrl ColladaImportProgress = Sim.FindObject<GuiProgressCtrl>("ColladaImportProgress");
               //todo colladaImportProgress
               /*
                *  ColladaImportProgress.savedProgress = LoadingProgress.getValue();
                *  ColladaImportProgress.savedText = LoadingProgressTxt.getValue();

                *  ColladaImportProgress.msgPrefix = "Importing " @ %msg;
                *  %msg = "Reading file into memory...";
                */ 
            }
            else if (Math.Abs(progress - 1.0) < 0.000001)
            {
               /*
                *    LoadingProgress.setValue( ColladaImportProgress.savedProgress );
                *    LoadingProgressTxt.setValue( ColladaImportProgress.savedText );
                */
            }

            /*
             *  %msg = ColladaImportProgress.msgPrefix @ ": " @ %msg;
             *
             *  %progressCtrl = LoadingProgress;
             *  %textCtrl = LoadingProgressTxt;
             */
         }
         else
         {
            // It's probably the editors using it
            if (Global.isFunction("updateToolTSShapeLoadProgress"))
            {
               Global.call("updateToolTSShapeLoadProgress", pProgress, pMsg);
            }
         }

         // Update progress indicators
         if (Math.Abs(progress) < 0.000001)
         {
            progressCtrl.setValue("0.001f");
            textCtrl.setText(pMsg);
         }
         else if(progress < 1.0f)
         {
            progressCtrl.setValue(pProgress);
            textCtrl.setText(pMsg);
         }

         GuiCanvas Canvas = Sim.FindObject<GuiCanvas>("Canvas");
         Canvas.repaint(33);
      }

      /// <summary>
      /// A helper function which will return the ghosted client object
      /// from a server object when connected to a local server.
      /// </summary>
      /// <param name="serverObject"></param>
      public static int serverToClientObject(SimObject serverObject)
      {
         Debug.Assert(Global.isObject("LocalClientConnection"), "serverToClientObject() - No local client connection found!");
         Debug.Assert(Global.isObject("ServerConnection"), "serverToClientObject() - No server connection found!");

         GameConnection LocalClientConnection = Sim.FindObject<GameConnection>("LocalClientConnection");
         GameConnection ServerConnection = Sim.FindObject<GameConnection>("ServerConnection");

         int ghostId = LocalClientConnection.getGhostID(serverObject.getId());
         if (ghostId == -1)
            return 0;

         return ServerConnection.resolveGhostID(ghostId);
      }
   }
}
 
 