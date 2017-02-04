using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   [ConsoleClass]
   internal class AL_LightSpecularVisualize : Torque3D.PostEffect
   {
      public AL_LightSpecularVisualize()
      {
         Name = "AL_LightSpecularVisualize";
         ShaderData AL_LightSpecularVisualizeShader = new ShaderData("AL_LightSpecularVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgLightSpecularVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgLightSpecularVisualizeP.glsl",

            SamplerNames =
            {
               [0] = "lightPrePassTex"
            },

            PixVersion = 2.0f
         };
         AL_LightSpecularVisualizeShader.registerSingleton();

         Shader = "AL_LightSpecularVisualizeShader";
         StateBlock = LightViz.AL_DefaultVisualizeState;

         Texture[0] = "#lightinfo";

         Target = "$backBuffer";
         RenderPriority = 9999;
      }

      public bool onEnabled()
      {
         LightViz.normalsVisualizer.disable();
         LightViz.depthVisualizer.disable();
         LightViz.lightColorVisualizer.disable();

         Globals.SetBool("AL_NormalsVisualizeVar", false);
         Globals.SetBool("AL_DepthVisualizeVar", false);
         Globals.SetBool("AL_LightColorVisualizeVar", false);

         return true;
      }
   }
}