using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torque3D;

namespace Game.Core
{
   class Main
   {
      /// <summary>
      /// Initialize core sub system functionality such as audio, the Canvas, PostFX,
      /// rendermanager, light managers, etc.
      ///
      /// Note that not all of these need to be initialized before the client, although
      /// the audio should and the canvas definitely needs to be.  I've put things here
      /// to distinguish between the purpose and functionality of the various client
      /// scripts.  Game specific script isn't needed until we reach the shell menus
      /// and start a game or connect to a server. We get the various subsystems ready
      /// to go, and then use initClient() to handle the rest of the startup sequence.
      ///
      /// If this is too convoluted we can reduce this complexity after futher testing
      /// to find exactly which subsystems should be readied before kicking things off. 
      /// </summary>
      public static void Init()
      {
         // We need to hook the missing/warn material stuff early, so do it here
         Globals.SetString("Core::MissingTexturePath", "core/images/missingTexture");
         Globals.SetString("Core::UnAvailableTexturePath", "core/images/unavailable");
         Globals.SetString("Core::WarningTexturePath", "core/images/warnMat");
         //todo Hmm, data and core mingle a bit here
         Globals.SetString("Core::CommonShaderPath", "data/shaders/common");

         // This is the path used by ShaderGen to cache procedural
         // shaders.  If left blank ShaderGen will only cache shaders
         // to memory and not to disk.
         //todo Hmm, data and core mingle a bit here
         Globals.SetString("shaderGen::cachePath", "data/shaders/procedural");

         //todo exec helperFunctions

         // We need some of the default GUI profiles in order to get the canvas and
         // other aspects of the GUI system ready.
         Profiles.Init();

         // This is a bit of a shortcut, but we'll load the client's default settings to 
         // ensure all the prefs get initialized correctly
         //todo this is also done in the root main
         string prefPath = Global.getPrefsPath();
         if (Global.isFile(prefPath + "/clientPrefs.cs"))
            Global.exec(prefPath + "/clientPrefs.cs");
         else
            Global.exec("data/defaults.cs");

         // Initialization of the various subsystems requires some of the preferences
         // to be loaded... so do that first.
         GlobalValues.Init();
         
         Canvas.Init();
         Cursor.Init();

         // Initialize some common material data, which we use here and there
         GfxData.CommonMaterialData.Init();

         RenderManager.Init();
         Lighting.Init();

         Audio.Init();
         Sfx.AudioData.Init();
         Sfx.AudioDescriptions.Init();
         Sfx.AudioEnvironments.Init();
         Sfx.AudioStates.Init();
         Sfx.AudioAmbience.Init();

         ParseArgs.Init();

         // Materials and Shaders for rendering various object types
         // todo CommonMaterialData might have to be initialized earlier
         GfxData.Shaders.Init();
         GfxData.TerrainBlock.Init();
         GfxData.Water.Init();
         GfxData.ScatterSky.Init();
         GfxData.Clouds.Init();

         // Initialize all core post effects
         PostEffect.Init();
         
         // Seed the random number generator.
         Global.setRandomSeed();
      }
   }
}
