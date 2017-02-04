using Game.Core.GfxData;
using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   [ConsoleClass]
   internal class AL_DepthVisualize : Torque3D.PostEffect
   {
      public static GFXStateBlockData AL_DepthVisualizeState;

      public static void Init()
      {
         // TODO is this necessary?
         AL_DepthVisualizeState = new GFXStateBlockData("AL_DepthVisualizeState")
         {
            ZDefined = true,
            ZEnable = false,
            ZWriteEnable = false,

            SamplersDefined = true,
            SamplerStates =
            {
               [0] = CommonMaterialData.SamplerClampPoint, // depth
               [1] = CommonMaterialData.SamplerClampLinear // viz color lookup
            }
         };
         AL_DepthVisualizeState.registerSingleton();
      }

      public AL_DepthVisualize()
      {
         Name = "AL_DepthVisualize";
         ShaderData AL_DepthVisualizeShader = new ShaderData("AL_DepthVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgDepthVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgDepthVisualizeP.glsl",

            SamplerNames =
            {
               [0] = "prepassBuffer",
               [1] = "depthViz"
            },

            PixVersion = 2.0f
         };
         AL_DepthVisualizeShader.registerSingleton();

         Shader = "AL_DepthVisualizeShader";
         StateBlock = LightViz.AL_DefaultVisualizeState;

         Texture[0] = "#prepass";
         Texture[1] = "core/lighting/advanced/depthviz";

         Target = "$backBuffer";
         RenderPriority = 9999;
      }

      public bool onEnabled()
      {
         LightViz.normalsVisualizer.disable();
         LightViz.lightColorVisualizer.disable();
         LightViz.lightSpecularVisualizer.disable();

         Globals.SetBool("AL_NormalsVisualizeVar", false);
         Globals.SetBool("AL_LightColorVisualizeVar", false);
         Globals.SetBool("AL_LightSpecularVisualizeVar", false);

         return true;
      }
   }
}