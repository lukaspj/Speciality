using Torque3D;

namespace Game.Core.LightingSystem.Shadowmaps
{
   class ShadowMaps
   {
      public static void Init()
      {
         new ShaderData("BlurDepthShader")
         {
            DXVertexShaderFile = "data/shaders/common/lighting/shadowMap/boxFilterV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/shadowMap/boxFilterP.hlsl",
            OGLVertexShaderFile = "data/shaders/common/lighting/shadowMap/gl/boxFilterV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/shadowMap/gl/boxFilterP.glsl",
            PixVersion = 2.0f
         }.registerSingleton();
      }
   }
}