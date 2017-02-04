using Torque3D;
using Torque3D.Util;

namespace Game.Core.GfxData
{
   class Water
   {
      public static void Init()
      {
         //-----------------------------------------------------------------------------
         // Water
         //-----------------------------------------------------------------------------

         ShaderData WaterShader = new ShaderData("WaterShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/waterV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/waterP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/gl/waterV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/gl/waterP.glsl",
            SamplerNames =
            {
               [0] = "$bumpMap", // noise
               [1] = "$prepassTex", // #prepass
               [2] = "$reflectMap", // $reflectbuff
               [3] = "$refractBuff", // $backbuff
               [4] = "$skyMap", // $cubemap   
               [5] = "$foamMap", // foam     
               [6] = "$depthGradMap" // depthMap ( color gradient ) 
            }, 

            PixVersion = 3.0f
         };
         WaterShader.registerSingleton();

         GFXSamplerStateData WaterSampler = new GFXSamplerStateData("WaterSampler")
         {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterAnisotropic,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MaxAnisotropy = 4
         };
         WaterSampler.registerSingleton();

         GFXStateBlockData WaterStateBlock = new GFXStateBlockData("WaterStateBlock")
         {
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = WaterSampler, // noise
               [1] = CommonMaterialData.SamplerClampPoint, // #prepass
               [2] = CommonMaterialData.SamplerClampLinear, // $reflectbuff
               [3] = CommonMaterialData.SamplerClampPoint, // $backbuff
               [4] = CommonMaterialData.SamplerWrapLinear, // $cubemap   
               [5] = CommonMaterialData.SamplerWrapLinear, // foam     
               [6] = CommonMaterialData.SamplerClampLinear // depthMap ( color gradient ) 
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullCCW
         };
         WaterStateBlock.registerSingleton();

         GFXStateBlockData UnderWaterStateBlock = new GFXStateBlockData("UnderWaterStateBlock", WaterStateBlock)
         {
            CullMode = GFXCullMode.GFXCullCCW
         };
         UnderWaterStateBlock.registerSingleton();

         CustomMaterial WaterMat = new CustomMaterial("WaterMat")
         {
            Shader = "WaterShader",
            StateBlock = WaterStateBlock,
            Version = 3.0f,
            UseAnisotropic = {[0] = true}
         };
         WaterMat.setFieldValue("sampler[prepassTex]", "#prepass");
         WaterMat.setFieldValue("sampler[reflectMap]", "$reflectbuff");
         WaterMat.setFieldValue("sampler[refractBuff]", "$backbuff");
         // These samplers are set in code not here.
         // This is to allow different WaterObject instances
         // to use this same material but override these textures
         // per instance.
         //sampler["bumpMap"] = "";    
         //sampler["skyMap"] = "";
         //sampler["foamMap"] = "";  
         //sampler["depthGradMap"] = "";
         WaterMat.registerSingleton();

         //-----------------------------------------------------------------------------
         // Underwater
         //-----------------------------------------------------------------------------

         new ShaderData("UnderWaterShader", WaterShader)
         {
            Defines = "UNDERWATER"
         }.registerSingleton();

         CustomMaterial UnderwaterMat = new CustomMaterial("UnderwaterMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.   
            //sampler["bumpMap"] = "art/images/water/noise02";
            //sampler["foamMap"] = "art/images/water/foam";

            Shader = "UnderWaterShader",
            StateBlock = UnderWaterStateBlock,
            Specular = {[0] = new ColorF(0.75f, 0.75f, 0.75f, 1.0f)},
            SpecularPower = {[0] = 48.0f},
            Version = 3.0f
         };
         UnderwaterMat.setFieldValue("sampler[prepassTex]", "#prepass");
         UnderwaterMat.setFieldValue("sampler[refractBuff]", "$backbuff");
         UnderwaterMat.registerSingleton();

         //-----------------------------------------------------------------------------
         // Basic Water
         //-----------------------------------------------------------------------------

         ShaderData WaterBasicShader = new ShaderData("WaterBasicShader")
         {
            DXVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/waterBasicV.hlsl",
            DXPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/waterBasicP.hlsl",
            OGLVertexShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/gl/waterBasicV.glsl",
            OGLPixelShaderFile = Globals.GetString("Core::CommonShaderPath") + "/water/gl/waterBasicP.glsl",
            SamplerNames =
            {
               [0] = "$bumpMap",
               [2] = "$reflectMap",
               [3] = "$refractBuff",
               [4] = "$skyMap",
               [5] = "$depthGradMap"
            },
            PixVersion = 2.0f
         };
         WaterBasicShader.registerSingleton();

         GFXStateBlockData WaterBasicStateBlock = new GFXStateBlockData("WaterBasicStateBlock")
         {
            SamplersDefined = true,
            SamplerStates =
            {
               [0] = WaterSampler, // noise
               [2] = CommonMaterialData.SamplerClampLinear, // $reflectbuff
               [3] = CommonMaterialData.SamplerClampPoint, // $backbuff
               [4] = CommonMaterialData.SamplerWrapLinear // $cubemap
            },
            CullDefined = true,
            CullMode = GFXCullMode.GFXCullCCW
         };
         WaterBasicStateBlock.registerSingleton();

         GFXStateBlockData UnderWaterBasicStateBlock = new GFXStateBlockData("UnderWaterBasicStateBlock",
            WaterBasicStateBlock)
         {
            CullMode = GFXCullMode.GFXCullCCW
         };
         UnderWaterBasicStateBlock.registerSingleton();

         CustomMaterial WaterBasicMat = new CustomMaterial("WaterBasicMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.     
            //sampler["bumpMap"] = "art/images/water/noise02";
            //sampler["skyMap"] = "$cubemap";   

            //sampler["prepassTex"] = "#prepass";
         
            Cubemap = "NewLevelSkyCubemap",
            Shader = "WaterBasicShader",
            StateBlock = WaterBasicStateBlock,
            Version = 2.0f
         };
         WaterBasicMat.setFieldValue("sampler[reflectMap]", "$reflectbuff");
         WaterBasicMat.setFieldValue("sampler[refractBuff]", "$backbuff");
         WaterBasicMat.registerSingleton();

         //-----------------------------------------------------------------------------
         // Basic UnderWater
         //-----------------------------------------------------------------------------

         new ShaderData("UnderWaterBasicShader", WaterBasicShader)
         {
            Defines = "UNDERWATER"
         }.registerSingleton();

         CustomMaterial UnderwaterBasicMat = new CustomMaterial("UnderwaterBasicMat")
         {
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.  
            //sampler["bumpMap"] = "art/images/water/noise02";
            //samplers["skyMap"] = "$cubemap";  

            //sampler["prepassTex"] = "#prepass";

            Shader = "UnderWaterBasicShader",
            StateBlock = UnderWaterBasicStateBlock,
            Version = 2.0f
         };
         UnderwaterBasicMat.setFieldValue("sampler[refractBuff]", "$backbuff");
         UnderwaterBasicMat.registerSingleton();
      }
   }
}