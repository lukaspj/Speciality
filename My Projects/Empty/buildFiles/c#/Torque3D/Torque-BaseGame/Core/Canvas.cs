using Torque3D;
using Torque3D.Util;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Core
{
   public class Canvas
   {
      public static DisplayCursorCanvas GameCanvas { get; set; }

      public static void Init()
      {
         // Constants for referencing video resolution preferences
         Globals.SetInt("WORD::RES_X", 0);
         Globals.SetInt("WORD::RES_Y", 1);
         Globals.SetInt("WORD::FULLSCREEN", 2);
         Globals.SetInt("WORD::BITDEPTH", 3);
         Globals.SetInt("WORD::REFRESH", 4);
         Globals.SetInt("WORD::AA", 5);
      }

      public static bool createCanvas(string windowTitle)
      {
         if (Globals.GetBool("isDedicated"))
         {
            Global.call("GFXInit::createNullDevice");
            return true;
         }

         // Create the Canvas
         GameCanvas = new DisplayCursorCanvas("Canvas");
         {
            //TODO: showWindow = false
         };
         GameCanvas.registerObject();

         // Set the window title
         if (Global.isObject("Canvas"))
         {
            GameCanvas.setWindowTitle(windowTitle);
            configureCanvas();
            return true;
         }

         Global.error("Canvas creation failed. Shutting down.");
         Global.quit();
         return false;
      }

      [ConsoleFunction]
      public static void configureCanvas()
      {
         // Setup a good default if we don't have one already.
         if (string.IsNullOrWhiteSpace(Globals.GetString("pref::Video::Resolution")))
            Globals.SetString("pref::Video::Resolution", "800 600");
         if (string.IsNullOrWhiteSpace(Globals.GetString("pref::Video::FullScreen")))
            Globals.SetBool("pref::Video::FullScreen", false);
         if (string.IsNullOrWhiteSpace(Globals.GetString("pref::Video::BitDepth")))
            Globals.SetInt("pref::Video::BitDepth", 32);
         if (string.IsNullOrWhiteSpace(Globals.GetString("pref::Video::RefreshRate")))
            Globals.SetInt("pref::Video::RefreshRate", 60);
         if (string.IsNullOrWhiteSpace(Globals.GetString("pref::Video::AA")))
            Globals.SetInt("pref::Video::AA", 4);

         string[] res = Globals.GetString("pref::Video::Resolution").Split(' ');
         uint resX = uint.Parse(res[0]);
         uint resY = uint.Parse(res[1]);
         bool fs = Globals.GetBool("pref::Video::FullScreen");
         string _bpp = Globals.GetString("pref::Video::BitDepth");
         uint bpp;
         uint.TryParse(_bpp, out bpp);
         int rate = Globals.GetInt("pref::Video::RefreshRate");
         int aa = Globals.GetInt("pref::Video::AA");

         if (!string.IsNullOrEmpty("cliFullscreen"))
         {
            fs = Globals.GetBool("cliFullscreen");
            Globals.SetString("cliFullscreen", "");
         }


         Global.echo("--------------");
         Global.echo($"Attempting to set resolution to \"{resX} {resY} {fs} {bpp} {rate} {aa}\"");

         Point3F deskRes = Global.getDesktopResolution();

         // We shouldn't be getting this any more but just in case...
         if (_bpp == "Default")
            bpp = (uint) deskRes.Z;

         GuiCanvas canvas = Sim.FindObjectByName<GuiCanvas>("Canvas");

         // Make sure we are running at a valid resolution
         if (!fs)
         {
            // Windowed mode has to use the same bit depth as the desktop
            bpp = (uint) deskRes.Z;

            // Windowed mode also has to run at a smaller resolution than the desktop
            if ((resX >= deskRes.X) || (resY >= deskRes.Y))
            {
               Global.warn(
                  "Warning: The requested windowed resolution is equal to or larger than the current desktop resolution. Attempting to find a better resolution");

               int resCount = canvas.getModeCount();
               for (int i = (resCount - 1); i >= 0; i--)
               {
                  string testRes = canvas.getMode(i);
                  string[] testResSplit = testRes.Split(' ');
                  uint testResX = uint.Parse(testResSplit[0]);
                  uint testResY = uint.Parse(testResSplit[1]);
                  uint testBPP;
                  Global.echo(testRes);
                  if (string.IsNullOrEmpty(testResSplit[2])) testBPP = 0;
                  else if (testResSplit[2].Trim().ToLower().Equals("false")) testBPP = 0;
                  else testBPP = uint.Parse(testResSplit[2]);

                  if (testBPP != bpp)
                     continue;

                  if ((testResX < deskRes.X) && (testResY < deskRes.Y))
                  {
                     // This will work as our new resolution
                     resX = testResX;
                     resY = testResY;

                     Global.warn($"Warning: Switching to \"{resX} {resY} {bpp}\"");

                     break;
                  }
               }
            }
         }

         Globals.SetString("pref::Video::Resolution", resX + " " + resY);
         Globals.SetBool("pref::Video::FullScreen", fs);
         Globals.SetInt("pref::Video::BitDepth", (int)bpp);
         Globals.SetInt("pref::Video::RefreshRate", rate);
         Globals.SetInt("pref::Video::AA", aa);
         
         string fsLabel = "No";
         if (fs)
            fsLabel = "Yes";

         Global.echo("Accepted Mode: \n" +
                     $"--Resolution : {resX} {resY}\n" +
                     $"--Full Screen : {fsLabel} \n" +
                     $"--Bits Per Pixel : {bpp} \n" +
                     $"--Refresh Rate : {rate} \n" +
                     $"--FSAA Level : {aa} \n" +
                     "--------------");

         // Actually set the new video mode
         canvas.setVideoMode(resX, resY, fs, bpp, (uint)rate, (uint)aa);

         Global.commandToServer("setClientAspectRatio".Tag(), resX.ToString(), resY.ToString());

         // FXAA piggybacks on the FSAA setting in $pref::Video::mode.
         if (Global.isObject("FXAA_PostEffect"))
         {
            Torque3D.PostEffect FXAA_PostEffect = Sim.FindObjectByName<Torque3D.PostEffect>("FXAA_PostEffect");
            FXAA_PostEffect.IsEnabled = (aa > 0);
         }
      }
   }
}