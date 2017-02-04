using Torque3D;
using Torque3D.Util;

namespace Game.Core.GfxData
{
   class ScatterSky
   {
      public static void Init()
      {
         new GFXStateBlockData("ScatterSkySBData")
         {
            CullMode = GFXCullMode.GFXCullNone,
            ZDefined = true,
            ZEnable = true,
            ZWriteEnable = false,
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = CommonMaterialData.SamplerClampLinear,
               [1] = CommonMaterialData.SamplerClampLinear
            },
            VertexColorEnable = true
         }.registerSingleton();

         new ShaderData("ScatterSkyShaderData")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/scatterSkyV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/scatterSkyP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/scatterSkyV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/scatterSkyP.glsl",
            SamplerNames = { [0] = "$nightSky" },
            PixVersion = 2.0f
         }.registerSingleton();
      }
   }
}