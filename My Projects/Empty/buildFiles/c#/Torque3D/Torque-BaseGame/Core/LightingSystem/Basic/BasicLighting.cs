using Game.Core.GfxData;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Basic
{
   class BasicLighting
   {
      public static RenderPassManager BL_ProjectedShadowRPM { get; set; }

      public static void Init()
      {
         ShadowFilter.Init();

         GFXStateBlockData BL_ProjectedShadowSBData = new GFXStateBlockData("BL_ProjectedShadowSBData")
         {
            BlendDefined = true,
            BlendEnable = true,
            BlendSrc = GFXBlend.GFXBlendDestColor,
            BlendDest = GFXBlend.GFXBlendZero,
            ZDefined = true,
            ZEnable = true,
            ZWriteEnable = false,
            SamplersDefined = true,
            SamplerStates = {[0] = CommonMaterialData.SamplerClampLinear},
            VertexColorEnable = true
         };
         BL_ProjectedShadowSBData.registerSingleton();

         new ShaderData("BL_ProjectedShadowShaderData")
         {
            DXVertexShaderFile = "data/shaders/common/projectedShadowV.hlsl",
            DXPixelShaderFile = "data/shaders/common/projectedShadowP.hlsl",
            OGLVertexShaderFile = "data/shaders/common/gl/projectedShadowV.glsl",
            OGLPixelShaderFile = "data/shaders/common/gl/projectedShadowP.glsl",

            SamplerNames = { [0] = "inputTex" },

            PixVersion = 2.0f
         }.registerSingleton();

         CustomMaterial BL_ProjectedShadowMaterial = new CustomMaterial("BL_ProjectedShadowMaterial")
         {
            Shader = "BL_ProjectedShadowShaderData",
            StateBlock = BL_ProjectedShadowSBData,
            Version = 2.0f,
            ForwardLit = true
         };
         BL_ProjectedShadowMaterial.setFieldValue("sampler[inputTex]", "$miscbuff");
         BL_ProjectedShadowMaterial.registerSingleton();
      }


      [ConsoleFunction]
      public static void onActivateBasicLM()
      {
         Torque3D.PostEffect HDRPostFx = Sim.FindObjectByName<Torque3D.PostEffect>("HDRPostFx");
         // If HDR is enabled... enable the special format token.
         if (!Globals.GetString("platform").Equals("macos") && HDRPostFx.isEnabled())
            Core.RenderManager.AL_FormatToken.enable();

         // Create render pass for projected shadow.
         BL_ProjectedShadowRPM = new RenderPassManager("BL_ProjectedShadowRPM");
         BL_ProjectedShadowRPM.registerObject();

         // Create the mesh bin and add it to the manager.
         RenderMeshMgr meshBin = new RenderMeshMgr();
         meshBin.registerObject();
         BL_ProjectedShadowRPM.addManager(meshBin);

         SimGroup RootGroup = Sim.FindObjectByName<SimGroup>("RootGroup");

         // Add both to the root group so that it doesn't
         // end up in the MissionCleanup instant group.
         RootGroup.add(BL_ProjectedShadowRPM);
         RootGroup.add(meshBin);
      }

      [ConsoleFunction]
      public static void onDeactivateBasicLM()
      {
         // Delete the pass manager which also deletes the bin.
         BL_ProjectedShadowRPM.delete();
      }

      [ConsoleFunction]
      public static void setBasicLighting()
      {
         Global.setLightManager("Basic Lighting");
      }
   }
}