using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   [ConsoleClass]
   internal class AL_LightColorVisualize : Torque3D.PostEffect
   {
      public AL_LightColorVisualize()
      {
         Name = "AL_LightColorVisualize";
         ShaderData AL_LightColorVisualizeShader = new ShaderData("AL_LightColorVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgLightColorVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgLightColorVisualizeP.glsl",

            SamplerNames =
            {
               [0] = "lightPrePassTex"
            },

            PixVersion = 2.0f
         };
         AL_LightColorVisualizeShader.registerSingleton();

         Shader = "AL_LightColorVisualizeShader";
         StateBlock = LightViz.AL_DefaultVisualizeState;

         Texture[0] = "#lightinfo";

         Target = "$backBuffer";
         RenderPriority = 9999;
      }

      public bool onEnabled()
      {
         LightViz.normalsVisualizer.disable();
         LightViz.depthVisualizer.disable();
         LightViz.lightSpecularVisualizer.disable();

         Globals.SetBool("AL_NormalsVisualizeVar", false);
         Globals.SetBool("AL_DepthVisualizeVar", false);
         Globals.SetBool("AL_LightSpecularVisualizeVar", false);

         return true;
      }
   }
}