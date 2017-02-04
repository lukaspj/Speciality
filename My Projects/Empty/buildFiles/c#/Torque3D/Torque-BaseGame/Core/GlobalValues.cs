using Torque3D;

namespace Game.Core
{
   class GlobalValues
   {
      public static void Init()
      {
         // ----------------------------------------------------------------------------
         // DInput keyboard, mouse, and joystick prefs
         // ----------------------------------------------------------------------------

         Globals.SetInt("pref::Input::MouseEnabled", 1);
         Globals.SetInt("pref::Input::LinkMouseSensitivity", 1);
         Globals.SetInt("pref::Input::KeyboardEnabled", 1);
         Globals.SetFloat("pref::Input::KeyboardTurnSpeed", 0.1f);
         Globals.SetFloat("pref::Input::JoystickEnabled", 0);

         // ----------------------------------------------------------------------------
         // Video Preferences
         // ----------------------------------------------------------------------------

         // Set directory paths for various data or default images.
         Globals.SetString("pref::Video::ProfilePath", "core/gfxprofile");
         Globals.SetString("pref::Video::missingTexturePath", "core/images/missingTexture.png");
         Globals.SetString("pref::Video::unavailableTexturePath", "core/images/unavailable.png");
         Globals.SetString("pref::Video::warningTexturePath", "core/images/warnMat.dds");

         Globals.SetInt("pref::Video::disableVerticalSync", 1);
         Globals.SetString("pref::Video::mode", "800 600 false 32 60 4");
         Globals.SetInt("pref::Video::defaultFenceCount", 0);

         // This disables the hardware FSAA/MSAA so that we depend completely on the FXAA
         // post effect which works on all cards and in deferred mode.  Note that the new
         // Intel Hybrid graphics on laptops will fail to initialize when hardware AA is
         // enabled... so you've been warned.
         Globals.SetBool("pref::Video::disableHardwareAA", true);

         Globals.SetBool("pref::Video::disableNormalmapping", false);
         Globals.SetBool("pref::Video::disablePixSpecular", false);
         Globals.SetBool("pref::Video::disableCubemapping", false);
         Globals.SetBool("pref::Video::disableParallaxMapping", false);

         // The number of mipmap levels to drop on loaded textures to reduce video memory
         // usage.  It will skip any textures that have been defined as not allowing down
         // scaling.
         Globals.SetInt("pref::Video::textureReductionLevel", 0);

         Globals.SetInt("pref::Video::defaultAnisotropy", 1);
         //$pref::Video::Gamma = 1.0;

         /// AutoDetect graphics quality levels the next startup.
         Globals.SetInt("pref::Video::autoDetect", 1);

         // ----------------------------------------------------------------------------
         // Shader stuff
         // ----------------------------------------------------------------------------

         // This is the path used by ShaderGen to cache procedural shaders.  If left
         // blank ShaderGen will only cache shaders to memory and not to disk.
         Globals.SetString("shaderGen::cachePath", "");

         // Uncomment to disable ShaderGen, useful when debugging
         //$ShaderGen::GenNewShaders = false;
   
         // Uncomment to dump disassembly for any shader that is compiled to disk.  These
         // will appear as shadername_dis.txt in the same path as the shader file.   
         //$gfx::disassembleAllShaders = true;

         // ----------------------------------------------------------------------------
         // Lighting and shadowing
         // ----------------------------------------------------------------------------

         // Uncomment to enable AdvancedLighting on the Mac (T3D 2009 Beta 3)
         //$pref::machax::enableAdvancedLighting = true;

         Globals.SetInt("sceneLighting::cacheSize", 20000);
         Globals.SetString("sceneLighting::purgeMethod", "lastCreated");
         Globals.SetInt("sceneLighting::cacheLighting", 1);

         Globals.SetFloat("pref::Shadows::textureScalar", 1.0f);
         Globals.SetBool("pref::Shadows::disable", false);

         // Sets the shadow filtering mode.
         //  None - Disables filtering.
         //  SoftShadow - Does a simple soft shadow
         //  SoftShadowHighQuality 
         Globals.SetString("pref::Shadows::filterMode", "SoftShadow");
      }
   }
}
