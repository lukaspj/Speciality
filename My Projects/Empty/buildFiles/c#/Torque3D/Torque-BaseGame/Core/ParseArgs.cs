using Torque3D;
using Torque3D.Util;

namespace Game.Core
{
   class ParseArgs
   {
      public static void Init()
      {
         
      }

      public static void Run()
      {
         int argc = Globals.GetInt("Game::argc");
         for (int i = 0; i < argc; i++)
         {
            string arg = Globals.GetString($"Game::argv{i}");
            string nextArg = Globals.GetString($"Game::argv{i+1}");
            bool hasNextArg = argc - i > 1;
            bool logModeSpecified = false;

            // Check for dedicated run
            /*if (arg.Equals("-dedicated"))
            {
               Globals.SetString("userDirs", Globals.GetString("defaultGame"));
               Globals.SetInt("dirCount", 1);
               Globals.SetBool("isDedicated", true);
            }*/

            switch (arg)
            {
               case "-commandLine":
                  Globals.SetString("userDirs", Globals.GetString("defaultGame"));
                  Globals.SetInt("dirCount", 1);
                  Globals.SetBool("isDedicated", true);
                  Globals.SetBool("Server::Dedicated", true);
                  Global.enableWinConsole(true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-mission":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("missionArg", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -mission <filename>");
                  }
                  break;
               case "-connect":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("JoinGameAddress", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -connect <ip_address>");
                  }
                  break;
               case "-log":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     int logMode = int.Parse(nextArg);
                     // Turn on console logging
                     if (logMode != 0)
                     {
                        // Dump existing console to logfile first
                        logMode += 4;
                     }
                     Global.setLogMode(logMode);
                     logModeSpecified = true;
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -log <Mode: 0,1,2>");
                  }
                  break;
               case "-dir":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     // Append the mod to the end of the current list
                     string userDirs = Globals.GetString("userDirs").Replace(nextArg, "") + ";" + nextArg;
                     Globals.SetString("userDirs", userDirs);

                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     Globals.SetInt("dirCount", Globals.GetInt("dirCount") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -dir <dir_name>");
                  }
                  break;
               // changed the default behavior of this command line arg. It now
               // defaults to ONLY loading the game, not tools 
               // default auto-run already loads in tools --SRZ 11/29/07
               case "-game":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     // Set the selected dir --NOTE: we no longer allow tools with this argument
                      /* 
                     if( $isDedicated )
                     {
                        $userDirs = $nextArg;
                        $dirCount = 1;
                     }
                     else
                     {
                        $userDirs = "tools;" @ $nextArg;
                        $dirCount = 2;
                     }
                     */
                     Globals.SetString("userDirs", nextArg);
                     Globals.SetInt("dirCount", 1);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -game <game_name>");
                  }
                  break;
               case "-console":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  Global.enableWinConsole(true);
                  break;
               case "-jSave":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Global.echo("Saving event log to journal: " + nextArg);
                     Global.saveJournal(nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -jSave <journal_name>");
                  }
                  break;
               case "-jPlay":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Global.playJournal(nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -jPlay <journal_name>");
                  }
                  break;
               case "-jPlayToVideo":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::journalName", nextArg);
                     Globals.SetBool("captureFromJournal", true);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -jPlayToVideo <journal_name>");
                  }
                  break;
               case "-vidCapFile":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::fileName", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -vidCapFile <ouput_video_name>");
                  }
                  break;
               case "-vidCapFPS":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::fps", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -vidCapFPS <ouput_video_framerate>");
                  }
                  break;
               case "-vidCapEncoder":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::encoder", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -vidCapEncoder <ouput_video_encoder>");
                  }
                  break;
               case "-vidCapWidth":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::width", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -vidCapWidth <ouput_video_width>");
                  }
                  break;
               case "-vidCapHeight":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     Globals.SetString("VideoCapture::height", nextArg);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -vidCapHeight <ouput_video_height>");
                  }
                  break;
               case "-level":
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if (hasNextArg)
                  {
                     int hasExt = nextArg.IndexOf(".mis");
                     string levelToLoad;
                     if (hasExt == -1)
                     {
                        levelToLoad = nextArg + " ";
                        for (i = i + 2; i < argc; i++)
                        {
                           arg = Globals.GetString($"Game::argv{i}");
                           hasExt = arg.IndexOf(".mis");

                           if (hasExt == -1)
                           {
                              levelToLoad = levelToLoad + arg + " ";
                           }
                           else
                           {
                              levelToLoad = levelToLoad + arg;
                              break;
                           }
                        }
                     }
                     else
                        levelToLoad = nextArg;
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  else
                  {
                     Global.error("Error: Missing Command Line argument. Usage: -level <level file name (no path), with or without extension>");
                  }
                  break;
               case "-worldeditor":
                  Globals.SetBool("startWorldEditor", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-guiEditor":
                  Globals.SetBool("startGUIEditor", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-help":
                  Globals.SetBool("displayHelp", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-compileAll":
                  Globals.SetBool("compileAll", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-compileTools":
                  Globals.SetBool("compileTools", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-genScript":
                  Globals.SetBool("genScript", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-fullscreen":
                  Globals.SetBool("cliFullscreen", true);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-windowed":
                  Globals.SetBool("cliFullscreen", false);
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-openGL":
                  Globals.SetString("pref::Video::displayDevice", "OpenGL");
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-directX":
                  Globals.SetString("pref::Video::displayDevice", "D3D");
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-autoVideo":
                  Globals.SetString("pref::Video::displayDevice", "");
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-prefs":
                  if (hasNextArg)
                  {
                     Global.exec(nextArg, true, true);
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-speed":
                  if (hasNextArg) {
                     Globals.SetInt("SShooter::TickSpeed", int.Parse(nextArg));
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-ai1":
                  if (hasNextArg)
                  {
                     Globals.SetString("SShooter::Ai1", nextArg);
                     if (!string.IsNullOrEmpty(Globals.GetString("SShooter::Ai2"))) {
                        Globals.SetBool("SShooter::QuickRun", true);
                     }
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               case "-ai2":
                  if (hasNextArg) {
                     Globals.SetString("SShooter::Ai2", nextArg);
                     if (!string.IsNullOrEmpty(Globals.GetString("SShooter::Ai1"))) {
                        Globals.SetBool("SShooter::QuickRun", true);
                     }
                     Globals.SetInt($"argUsed{i + 1}", Globals.GetInt($"argUsed{i + 1}") + 1);
                     i++;
                  }
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  break;
               default:
                  Globals.SetInt($"argUsed{i}", Globals.GetInt($"argUsed{i}") + 1);
                  if(string.IsNullOrEmpty(Globals.GetString("userDirs")))
                     Globals.SetString("userDirs", arg);
                  break;
            }
         }

         //-----------------------------------------------
         // Play journal to video file?
         if (Globals.GetBool("VideoCapture::captureFromJournal") && !string.IsNullOrEmpty("VideoCapture::journalName"))
         {
            if(string.IsNullOrEmpty(Globals.GetString("VideoCapture::fileName")))
               Globals.SetString("VideoCapture::fileName", Globals.GetString("VideoCapture::journalName"));


            if(string.IsNullOrEmpty(Globals.GetString("VideoCapture::encoder")))
               Globals.SetString("VideoCapture::encoder", "THEORA");


            if(string.IsNullOrEmpty(Globals.GetString("VideoCapture::fps")))
               Globals.SetInt("VideoCapture::fps", 30);


            if(string.IsNullOrEmpty(Globals.GetString("VideoCapture::width")))
               Globals.SetInt("VideoCapture::width", 0);


            if(string.IsNullOrEmpty(Globals.GetString("VideoCapture::height")))
               Globals.SetInt("VideoCapture::height", 0);

            Global.playJournalToVideo(
               Globals.GetString("VideoCapture::journalName"),
               Globals.GetString("VideoCapture::fileName"),
               Globals.GetString("VideoCapture::encoder"),
               Globals.GetFloat("VideoCapture::fps"),
               new Point2I(Globals.GetInt("VideoCapture::width"), Globals.GetInt("VideoCapture::height")));
         }
      }
   }
}
