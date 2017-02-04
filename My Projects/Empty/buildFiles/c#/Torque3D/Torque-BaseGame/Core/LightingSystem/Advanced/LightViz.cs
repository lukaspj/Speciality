using Game.Core.GfxData;
using Torque3D;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Advanced
{
   class LightViz
   {
      public static GFXStateBlockData AL_DefaultVisualizeState;
      public static AL_DepthVisualize depthVisualizer;
      public static AL_LightColorVisualize lightColorVisualizer;
      public static AL_LightSpecularVisualize lightSpecularVisualizer;
      public static AL_NormalsVisualize normalsVisualizer;
      public static AL_GlowVisualize glowVisualizer;

      public static void Init()
      {
         AL_DefaultVisualizeState = new GFXStateBlockData("AL_DefaultVisualizeState")
         {
            BlendDefined = true,
            BlendEnable = true,
            BlendSrc = GFXBlend.GFXBlendSrcAlpha,
            BlendDest = GFXBlend.GFXBlendInvSrcAlpha,

            ZDefined = true,
            ZEnable = false,
            ZWriteEnable = false,

            SamplersDefined = true,
            SamplerStates =
            {
               [0] = CommonMaterialData.SamplerClampPoint, // #prepass
               [1] = CommonMaterialData.SamplerClampLinear // depthviz
            }
         };
         AL_DefaultVisualizeState.registerSingleton();

         depthVisualizer = new AL_DepthVisualize();
         depthVisualizer.registerSingleton();
         normalsVisualizer = new AL_NormalsVisualize();
         normalsVisualizer.registerSingleton();
         glowVisualizer = new AL_GlowVisualize();
         glowVisualizer.registerSingleton();
         lightColorVisualizer = new AL_LightColorVisualize();
         lightColorVisualizer.registerSingleton();
         lightSpecularVisualizer = new AL_LightSpecularVisualize();
         lightSpecularVisualizer.registerSingleton();
      }

      /// <summary>
      ///    Toggles the visualization of the AL depth buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleDepthViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_DepthVisualizeVar", !depthVisualizer.isEnabled());
            depthVisualizer.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            depthVisualizer.enable();
         else
            depthVisualizer.disable();
      }

      /// <summary>
      ///    Toggles the visualization of the AL glow buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleGlowViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_GlowVisualizeVar", !glowVisualizer.isEnabled());
            glowVisualizer.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            glowVisualizer.enable();
         else
            glowVisualizer.disable();
      }

      /// <summary>
      ///    Toggles the visualization of the AL normals buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleNormalsViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_NormalsVisualizeVar", !normalsVisualizer.isEnabled());
            normalsVisualizer.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            normalsVisualizer.enable();
         else
            normalsVisualizer.disable();
      }

      /// <summary>
      ///    Toggles the visualization of the AL lighting color buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleLightColorViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_LightColorVisualizeVar", !lightColorVisualizer.isEnabled());
            lightColorVisualizer.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            lightColorVisualizer.enable();
         else
            lightColorVisualizer.disable();
      }

      /// <summary>
      ///    Toggles the visualization of the AL lighting specular power buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleLightSpecularViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_LightSpecularVisualizeVar", !lightSpecularVisualizer.isEnabled());
            lightSpecularVisualizer.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            lightSpecularVisualizer.enable();
         else
            lightSpecularVisualizer.disable();
      }

      /// <summary>
      ///    Toggles the visualization of the AL back buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleBackbufferViz(string pEnable)
      {
         if (string.IsNullOrEmpty(pEnable))
         {
            Globals.SetBool("AL_BackbufferVisualizeVar", DeferredShading.AL_DeferredShading.isEnabled());
            DeferredShading.AL_DeferredShading.toggle();
         }
         else if (GenericMarshal.StringToBool(pEnable))
            DeferredShading.AL_DeferredShading.disable();
         else
            DeferredShading.AL_DeferredShading.enable();
      }
   }
}