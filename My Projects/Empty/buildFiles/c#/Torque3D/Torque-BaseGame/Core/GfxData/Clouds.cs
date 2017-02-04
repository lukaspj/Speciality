using Torque3D;

namespace Game.Core.GfxData
{
   class Clouds
   {
      public static void Init()
      {
         //------------------------------------------------------------------------------
         // CloudLayer
         //------------------------------------------------------------------------------

         new ShaderData("CloudLayerShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/cloudLayerV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/cloudLayerP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/cloudLayerV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/cloudLayerP.glsl",

            SamplerNames = { [0] = "$normalHeightMap" },

            PixVersion = 2.0f
         }.registerSingleton();

         //------------------------------------------------------------------------------
         // BasicClouds
         //------------------------------------------------------------------------------

         new ShaderData("BasicCloudsShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/basicCloudsV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/basicCloudsP.hlsl",

            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/basicCloudsV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/basicCloudsP.glsl",

            SamplerNames = { [0] = "$diffuseMap" },

            PixVersion = 2.0f
         }.registerSingleton();
      }
   }
}