using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   class AdvancedLighting
   {
      public static void Init()
      {
         Shaders.Init();
         LightViz.Init();
         AL_DepthVisualize.Init();
         ShadowViz.Init();
         ShadowVizGui.Init();
         DeferredShading.Init();
      }

      [ConsoleFunction]
      public static void onActivateAdvancedLM()
      {
         // Don't allow the offscreen target on OSX.
         if ( Globals.GetString("platform").Equals("macos" ))
            return;

         // On the Xbox360 we know what will be enabled so don't do any trickery to
         // disable MSAA
         if ( Globals.GetString("platform").Equals("xenon" ))
            return;

         // Enable the offscreen target so that AL will work
         // with MSAA back buffers and for HDR rendering.   
         RenderManager.AL_FormatToken.enable();

         // Activate Deferred Shading
         DeferredShading.AL_DeferredShading.enable();
      }

      [ConsoleFunction]
      public static void onDeactivateAdvancedLM()
      {
         // Disable the offscreen render target.
         RenderManager.AL_FormatToken.disable();

         // Deactivate Deferred Shading
         DeferredShading.AL_DeferredShading.disable();
      }

      [ConsoleFunction]
      public static void setAdvancedLighting()
      {
         Global.setLightManager("Advanced Lighting");
      }
   }
}