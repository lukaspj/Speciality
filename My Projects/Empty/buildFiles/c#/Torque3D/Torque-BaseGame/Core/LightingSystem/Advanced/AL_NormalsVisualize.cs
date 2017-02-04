using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   [ConsoleClass]
   internal class AL_NormalsVisualize : Torque3D.PostEffect
   {
      public AL_NormalsVisualize()
      {
         Name = "AL_NormalsVisualize";

         ShaderData AL_NormalsVisualizeShader = new ShaderData("AL_NormalsVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgNormalVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgNormalVisualizeP.glsl",

            SamplerNames =
            {
               [0] = "prepassTex"
            },

            PixVersion = 2.0f
         };
         AL_NormalsVisualizeShader.registerSingleton();

         Shader = "AL_NormalsVisualizeShader";
         StateBlock = LightViz.AL_DefaultVisualizeState;

         Texture[0] = "#prepass";

         Target = "$backBuffer";
         RenderPriority = 9999;
      }

      public bool onEnabled()
      {
         LightViz.depthVisualizer.disable();
         LightViz.lightColorVisualizer.disable();
         LightViz.lightSpecularVisualizer.disable();

         Globals.SetBool("AL_DepthVisualizeVar", false);
         Globals.SetBool("AL_LightColorVisualizeVar", false);
         Globals.SetBool("AL_LightSpecularVisualizeVar", false);

         return true;
      }
   }
}