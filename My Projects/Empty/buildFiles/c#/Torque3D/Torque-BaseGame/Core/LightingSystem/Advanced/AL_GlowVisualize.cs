using Game.Core.GfxData;
using Torque3D;

namespace Game.Core.LightingSystem.Advanced
{
   [ConsoleClass]
   internal class AL_GlowVisualize : Torque3D.PostEffect
   {
      public AL_GlowVisualize()
      {
         Name = "AL_GlowVisualize";

         ShaderData AL_GlowVisualizeShader = new ShaderData("AL_GlowVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgGlowVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgGlowVisualizeP.glsl",

            SamplerNames =
            {
               [0] = "glowBuffer"
            },

            PixVersion = 2.0f
         };
         AL_GlowVisualizeShader.registerSingleton();

         Shader = "AL_GlowVisualizeShader";
         StateBlock = LightViz.AL_DefaultVisualizeState;

         Texture[0] = "#glowBuffer";

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