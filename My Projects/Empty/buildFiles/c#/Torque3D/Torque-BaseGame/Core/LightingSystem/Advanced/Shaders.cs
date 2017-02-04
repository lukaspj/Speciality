using Game.Core.GfxData;
using Torque3D;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Advanced
{
   class Shaders
   {
      public static void Init()
      {
         // Vector Light State
         GFXStateBlockData AL_VectorLightState = new GFXStateBlockData("AL_VectorLightState")
         {
            BlendDefined = true,
            BlendEnable = true,
            BlendSrc = GFXBlend.GFXBlendOne,
            BlendDest = GFXBlend.GFXBlendOne,
            BlendOp = GFXBlendOp.GFXBlendOpAdd,
            ZDefined = true,
            ZEnable = false,
            ZWriteEnable = false,
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = CommonMaterialData.SamplerClampPoint, // G-buffer
               // Shadow Map (Do not change this to linear, as all cards can not filter equally.)
               [1] = CommonMaterialData.SamplerClampPoint,
               [2] = CommonMaterialData.SamplerClampLinear, // SSAO Mask
               [3] = CommonMaterialData.SamplerWrapPoint // Random Direction Map
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullNone,
            StencilDefined = true,
            StencilEnable = true,
            StencilFailOp = GFXStencilOp.GFXStencilOpKeep,
            StencilZFailOp = GFXStencilOp.GFXStencilOpKeep,
            StencilPassOp = GFXStencilOp.GFXStencilOpKeep,
            StencilFunc = GFXCmpFunc.GFXCmpLess,
            StencilRef = 0
         };
         AL_VectorLightState.setFieldValue("mSamplerNames[0]", "prePassBuffer"); //todo not used anywhere
         AL_VectorLightState.setFieldValue("mSamplerNames[1]", "shadowMap");
         AL_VectorLightState.setFieldValue("mSamplerNames[2]", "ssaoMask");
         AL_VectorLightState.registerSingleton();

         // Vector Light Material
         ShaderData AL_VectorLightShader = new ShaderData("AL_VectorLightShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/farFrustumQuadV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/vectorLightP.hlsl",
            OGLVertexShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/farFrustumQuadV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/vectorLightP.glsl",
            SamplerNames =
            {
               [0] = "$prePassBuffer",
               [1] = "$shadowMap",
               [2] = "$dynamicShadowMap",
               [3] = "$ssaoMask",
               [4] = "$gTapRotationTex",
               [5] = "$lightBuffer",
               [6] = "$colorBuffer",
               [7] = "$matInfoBuffer"
            },
            PixVersion = 3.0f
         };
         AL_VectorLightShader.registerSingleton();

         CustomMaterial AL_VectorLightMaterial = new CustomMaterial("AL_VectorLightMaterial")
         {
            Shader = "AL_VectorLightShader",
            StateBlock = AL_VectorLightState,
            Target = "lightinfo"

            //todo pixVersion 3.0f
         };
         AL_VectorLightMaterial.setFieldValue("sampler[prepassBuffer]", "#prepass");
         AL_VectorLightMaterial.setFieldValue("sampler[shadowMap]", "$dynamiclight");
         AL_VectorLightMaterial.setFieldValue("sampler[dynamicShadowMap]", "$dynamicShadowMap");
         AL_VectorLightMaterial.setFieldValue("sampler[ssaoMask]", "#ssaoMask");
         AL_VectorLightMaterial.setFieldValue("sampler[lightBuffer]", "#lightinfo");
         AL_VectorLightMaterial.setFieldValue("sampler[colorBuffer]", "#color");
         AL_VectorLightMaterial.setFieldValue("sampler[matInfoBuffer]", "#matinfo");
         AL_VectorLightMaterial.registerSingleton();

         //------------------------------------------------------------------------------

         // Convex-geometry light states
         GFXStateBlockData AL_ConvexLightState = new GFXStateBlockData("AL_ConvexLightState")
         {
            BlendDefined = true,
            BlendEnable = true,
            BlendSrc = GFXBlend.GFXBlendOne,
            BlendDest = GFXBlend.GFXBlendOne,
            BlendOp = GFXBlendOp.GFXBlendOpAdd,
            ZDefined = true,
            ZEnable = true,
            ZWriteEnable = false,
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = CommonMaterialData.SamplerClampPoint, // G-buffer
               [1] = CommonMaterialData.SamplerClampPoint,
               // Shadow Map (Do not use linear, these are perspective projections)
               [2] = CommonMaterialData.SamplerClampLinear, // Cookie Map
               [3] = CommonMaterialData.SamplerWrapPoint // Random Direction Map
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullCW,
            StencilDefined = true,
            StencilEnable = true,
            StencilFailOp = GFXStencilOp.GFXStencilOpKeep,
            StencilZFailOp = GFXStencilOp.GFXStencilOpKeep,
            StencilPassOp = GFXStencilOp.GFXStencilOpKeep,
            StencilFunc = GFXCmpFunc.GFXCmpLess,
            StencilRef = 0
         };
         AL_ConvexLightState.setFieldValue("mSamplerNames[0]", "prePassBuffer");
         AL_ConvexLightState.setFieldValue("mSamplerNames[1]", "shadowMap");
         AL_ConvexLightState.registerSingleton();


         // Point Light Material
         ShaderData AL_PointLightShader = new ShaderData("AL_PointLightShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/farFrustumQuadV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/pointLightP.hlsl",
            OGLVertexShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/farFrustumQuadV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/pointLightP.glsl",
            SamplerNames =
            {
               [0] = "$prePassBuffer",
               [1] = "$shadowMap",
               [2] = "$dynamicShadowMap",
               [3] = "cookieMap",
               [4] = "$gTapRotationTex",
               [5] = "$lightBuffer",
               [6] = "$colorBuffer",
               [7] = "$matInfoBuffer"
            },
            PixVersion = 3.0f
         };
         AL_PointLightShader.registerSingleton();

         CustomMaterial AL_PointLightMaterial = new CustomMaterial("AL_PointLightMaterial")
         {
            Shader = "AL_PointLightShader",
            StateBlock = AL_ConvexLightState,
            Target = "lightinfo"

            //todo pixVersion 3.0f
         };
         AL_PointLightMaterial.setFieldValue("sampler[prepassBuffer]", "#prepass");
         AL_PointLightMaterial.setFieldValue("sampler[shadowMap]", "$dynamiclight");
         AL_PointLightMaterial.setFieldValue("sampler[dynamicShadowMap]", "$dynamicShadowMap");
         AL_PointLightMaterial.setFieldValue("sampler[cookieMap]", "$dynamiclightmask");
         AL_PointLightMaterial.setFieldValue("sampler[lightBuffer]", "#lightinfo");
         AL_PointLightMaterial.setFieldValue("sampler[colorBuffer]", "#color");
         AL_PointLightMaterial.setFieldValue("sampler[matInfoBuffer]", "#matinfo");
         AL_PointLightMaterial.registerSingleton();


         // Spot Light Material
         ShaderData AL_SpotLightShader = new ShaderData("AL_SpotLightShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/farFrustumQuadV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/spotLightP.hlsl",
            OGLVertexShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/farFrustumQuadV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/spotLightP.glsl",
            SamplerNames =
            {
               [0] = "$prePassBuffer",
               [1] = "$shadowMap",
               [2] = "$dynamicShadowMap",
               [3] = "cookieMap",
               [4] = "$gTapRotationTex",
               [5] = "$lightBuffer",
               [6] = "$colorBuffer",
               [7] = "$matInfoBuffer"
            },
            PixVersion = 3.0f
         };
         AL_SpotLightShader.registerSingleton();

         CustomMaterial AL_SpotLightMaterial = new CustomMaterial("AL_SpotLightMaterial")
         {
            Shader = "AL_SpotLightShader",
            StateBlock = AL_ConvexLightState,
            Target = "lightinfo"

            //todo pixVersion 3.0f
         };
         AL_SpotLightMaterial.setFieldValue("sampler[prepassBuffer]", "#prepass");
         AL_SpotLightMaterial.setFieldValue("sampler[shadowMap]", "$dynamiclight");
         AL_SpotLightMaterial.setFieldValue("sampler[dynamicShadowMap]", "$dynamicShadowMap");
         AL_SpotLightMaterial.setFieldValue("sampler[cookieMap]", "$dynamiclightmask");
         AL_SpotLightMaterial.setFieldValue("sampler[lightBuffer]", "#lightinfo");
         AL_SpotLightMaterial.setFieldValue("sampler[colorBuffer]", "#color");
         AL_SpotLightMaterial.setFieldValue("sampler[matInfoBuffer]", "#matinfo");
         AL_SpotLightMaterial.registerSingleton();

         // This material is used for generating prepass 
         // materials for objects that do not have materials.
         Material AL_DefaultPrePassMaterial = new Material("AL_DefaultPrePassMaterial")
         {
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            DiffuseColor = {[0] = ColorF.WHITE}
         };
         AL_DefaultPrePassMaterial.registerSingleton();

         // This material is used for generating shadow 
         // materials for objects that do not have materials.
         Material AL_DefaultShadowMaterial = new Material("AL_DefaultShadowMaterial")
         {
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            DiffuseColor = {[0] = ColorF.WHITE},

            // This is here mostly for terrain which uses
            // this material to create its shadow material.
            //
            // At sunset/sunrise the sun is looking thru 
            // backsides of the terrain which often are not
            // closed.  By changing the material to be double
            // sided we avoid holes in the shadowed geometry.
            //
            DoubleSided = true
         };
         AL_DefaultShadowMaterial.registerSingleton();

         // Particle System Point Light Material
         ShaderData AL_ParticlePointLightShader = new ShaderData("AL_ParticlePointLightShader")
         {
            DXVertexShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/particlePointLightV.hlsl",
            DXPixelShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/particlePointLightP.hlsl",
            OGLVertexShaderFile =
               Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/convexGeometryV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/lighting/advanced/gl/pointLightP.glsl",
            SamplerNames = {[0] = "$prePassBuffer"}

            //todo pixVersion = 3.0,
         };
         AL_ParticlePointLightShader.registerSingleton();

         CustomMaterial AL_ParticlePointLightMaterial = new CustomMaterial("AL_ParticlePointLightMaterial")
         {
            Shader = "AL_ParticlePointLightShader",
            StateBlock = AL_ConvexLightState,
            Target = "lightinfo"

            //todo PixVersion = 3.0
         };
         AL_ParticlePointLightMaterial.setFieldValue("Sampler[prePassBuffer]", "#prepass");
         AL_ParticlePointLightMaterial.registerSingleton();
      }
   }
}