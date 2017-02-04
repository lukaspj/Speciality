using Torque3D;

namespace Game.Core.GfxData
{
   class Shaders
   {
      public static void Init()
      {
         //-----------------------------------------------------------------------------
         //  This file contains shader data necessary for various engine utility functions
         //-----------------------------------------------------------------------------

         new ShaderData("ParticlesShaderData")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/particlesV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/particlesP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/particlesV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/particlesP.glsl",
            SamplerNames =
            {
               [0] = "$diffuseMap",
               [1] = "$prepassTex",
               [2] = "$paraboloidLightMap"
            },
            PixVersion = 2.0f
         }.registerSingleton();

         new ShaderData("OffscreenParticleCompositeShaderData")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/particleCompositeV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/particleCompositeP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/particleCompositeV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/particleCompositeP.glsl",
            SamplerNames =
            {
               [0] = "$colorSource",
               [1] = "$edgeSource"
            },
            PixVersion = 2.0f
         }.registerSingleton();

         //-----------------------------------------------------------------------------
         // Planar Reflection
         //-----------------------------------------------------------------------------
         new ShaderData("ReflectBump")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/planarReflectBumpV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/planarReflectBumpP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/planarReflectBumpV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/planarReflectBumpP.glsl",
            SamplerNames =
            {
               [0] = "$diffuseMap",
               [1] = "$refractMap",
               [2] = "$bumpMap"
            },
            PixVersion = 2.0f
         }.registerSingleton();

         new ShaderData("Reflect")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/planarReflectV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/planarReflectP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/planarReflectV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/planarReflectP.glsl",
            SamplerNames =
            {
               [0] = "$diffuseMap",
               [1] = "$refractMap"
            },
            PixVersion = 1.4f
         }.registerSingleton();

         //-----------------------------------------------------------------------------
         // fxFoliageReplicator
         //-----------------------------------------------------------------------------
         new ShaderData("fxFoliageReplicatorShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/fxFoliageReplicatorV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/fxFoliageReplicatorP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/fxFoliageReplicatorV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/gl/fxFoliageReplicatorP.glsl",
            SamplerNames =
            {
               [0] = "$diffuseMap",
               [1] = "$alphaMap"
            },
            PixVersion = 1.4f
         }.registerSingleton();

         new ShaderData("VolumetricFogPrePassShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogPreV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogPreP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogPreV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogPreP.glsl",

            PixVersion = 3.0f
         }.registerSingleton();

         new ShaderData("VolumetricFogShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogP.glsl",

            SamplerNames =
            {
               [0] = "$prepassTex",
               [1] = "$depthBuffer",
               [2] = "$frontBuffer",
               [3] = "$density"
            },

            PixVersion = 3.0f
         }.registerSingleton();

         new ShaderData("VolumetricFogReflectionShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogPreV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/VFogRefl.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogPreV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogRefl.glsl",

            PixVersion = 3.0f
         }.registerSingleton();
      }
   }
}