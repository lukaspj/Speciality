using Torque3D;

namespace Game.Core.GfxData
{
   class TerrainBlock
   {
      public static void Init()
      {
         // Used when generating the blended base texture.
         new ShaderData("TerrainBlendShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/terrain/blendV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/terrain/blendP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/terrain/gl/blendV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/terrain/gl/blendP.glsl",

            SamplerNames =
            {
               [0] = "layerTex",
               [1] = "textureMap"
            },

            PixVersion = 2.0f
         }.registerSingleton();
      }
   }
}