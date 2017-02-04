using System.Diagnostics;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Core
{
   public class RenderManager
   {
      public static Torque3D.PostEffect AL_FormatCopy;

      public static RenderFormatToken AL_FormatToken { get; set; }

      public static void Init()
      {
         // This post effect is used to copy data from the non-MSAA back-buffer to the
         // device back buffer (which could be MSAA). It must be declared here so that
         // it is initialized when 'AL_FormatToken' is initialzed.

         GFXStateBlockData AL_FormatTokenState = new GFXStateBlockData("AL_FormatTokenState",
            PostEffect.PFX_DefaultStateBlock)
         {
            SamplersDefined = true,
            SamplerStates = {[0] = GfxData.CommonMaterialData.SamplerClampPoint}
         };
         AL_FormatTokenState.registerSingleton();

         AL_FormatCopy = new Torque3D.PostEffect("AL_FormatCopy")
         {
            // This PostEffect is used by 'AL_FormatToken' directly. It is never added to
            // the PostEffectManager. Do not call enable() on it.
            IsEnabled = false,
            AllowReflectPass = true,

            Shader = "PFX_PassthruShader",
            StateBlock = AL_FormatTokenState,

            Texture = {[0] = "$inTex"},
            Target = "$backbuffer"
         };
         AL_FormatCopy.registerObject();
      }

      [ConsoleFunction]
      public static void initRenderManager()
      {
         Debug.Assert(!Global.isObject("DiffuseRenderPassManager"),
            "initRenderManager() - DiffuseRenderPassManager already initialized!");

         RenderPassManager diffuseRenderPassManager = new RenderPassManager("DiffuseRenderPassManager");
         diffuseRenderPassManager.registerObject();

         // This token, and the associated render managers, ensure that driver MSAA
         // does not get used for Advanced Lighting renders.  The 'AL_FormatResolve'
         // PostEffect copies the result to the backbuffer.
         AL_FormatToken = new RenderFormatToken("AL_FormatToken")
         {
            Enabled = false,
            Format = GFXFormat.GFXFormatR16G16B16A16F,
            DepthFormat = GFXFormat.GFXFormatD24S8,
            AaLevel = 0, // -1 = match backbuffer

            // The contents of the back buffer before this format token is executed
            // is provided in $inTex
            CopyEffect = AL_FormatCopy,

            // The contents of the render target created by this format token is
            // provided in $inTex
            ResolveEffect = AL_FormatCopy
         };
         System.Console.WriteLine(AL_FormatToken.Format);
         AL_FormatToken.registerObject();
         
         diffuseRenderPassManager.addManager(new RenderPassStateBin(true)
         {
            RenderOrder = 0.001f,
            StateToken = AL_FormatToken
         });

         // We really need to fix the sky to render after all the
         // meshes... but that causes issues in reflections.
         diffuseRenderPassManager.addManager(new RenderObjectMgr("SkyBin", true)
         {
            BinType = "Sky",
            RenderOrder = 0.1f,
            ProcessAddOrder = 0.1f
         });

         //DiffuseRenderPassManager.addManager( new RenderVistaMgr()               { bintype = "Vista"; renderOrder = 0.15; processAddOrder = 0.15; } );

         diffuseRenderPassManager.addManager(new RenderObjectMgr("BeginBin", true)
         {
            BinType = "Begin",
            RenderOrder = 0.2f,
            ProcessAddOrder = 0.2f
         });

         // Normal mesh rendering.
         diffuseRenderPassManager.addManager(new RenderTerrainMgr("TerrainBin", true) {RenderOrder = 0.4f, ProcessAddOrder = 0.4f, BasicOnly = true});

         diffuseRenderPassManager.addManager(new RenderMeshMgr("MeshBin", true)
         {
            BinType = "Mesh",
            RenderOrder = 0.5f,
            ProcessAddOrder = 0.5f,
            BasicOnly = true
         });

         diffuseRenderPassManager.addManager(new RenderImposterMgr("ImposterBin", true) {RenderOrder = 0.56f, ProcessAddOrder = 0.56f});

         diffuseRenderPassManager.addManager(new RenderObjectMgr("ObjectBin", true)
         {
            BinType = "Object",
            RenderOrder = 0.6f,
            ProcessAddOrder = 0.6f
         });

         diffuseRenderPassManager.addManager(new RenderObjectMgr("ShadowBin", true)
         {
            BinType = "Shadow",
            RenderOrder = 0.7f,
            ProcessAddOrder = 0.7f
         });
         diffuseRenderPassManager.addManager(new RenderMeshMgr("DecalRoadBin", true)
         {
            BinType = "DecalRoad",
            RenderOrder = 0.8f,
            ProcessAddOrder = 0.8f
         });
         diffuseRenderPassManager.addManager(new RenderMeshMgr("DecalBin", true)
         {
            BinType = "Decal",
            RenderOrder = 0.81f,
            ProcessAddOrder = 0.81f
         });
         diffuseRenderPassManager.addManager(new RenderOcclusionMgr("OccluderBin", true)
         {
            BinType = "Occluder",
            RenderOrder = 0.9f,
            ProcessAddOrder = 0.9f
         });

         // We now render translucent objects that should handle
         // their own fogging and lighting.

         // Note that the fog effect is triggered before this bin.
         diffuseRenderPassManager.addManager(new RenderObjectMgr("ObjTranslucentBin", true)
         {
            BinType = "ObjectTranslucent",
            RenderOrder = 1.0f,
            ProcessAddOrder = 1.0f
         });

         diffuseRenderPassManager.addManager(new RenderObjectMgr("WaterBin", true)
         {
            BinType = "Water",
            RenderOrder = 1.2f,
            ProcessAddOrder = 1.2f
         });
         diffuseRenderPassManager.addManager(new RenderObjectMgr("FoliageBin", true)
         {
            BinType = "Foliage",
            RenderOrder = 1.3f,
            ProcessAddOrder = 1.3f
         });
         diffuseRenderPassManager.addManager(new RenderParticleMgr("ParticleBin", true) {RenderOrder = 1.35f, ProcessAddOrder = 1.35f});
         diffuseRenderPassManager.addManager(new RenderTranslucentMgr("TranslucentBin", true) {RenderOrder = 1.4f, ProcessAddOrder = 1.4f});

         diffuseRenderPassManager.addManager(new RenderTranslucentMgr("FogBin", true) { BinType = "ObjectVolumetricFog", RenderOrder = 1.45f, ProcessAddOrder = 1.45f});

         // Note that the GlowPostFx is triggered after this bin.
         diffuseRenderPassManager.addManager(new RenderGlowMgr("GlowBin", true)
         {
            RenderOrder = 1.5f,
            ProcessAddOrder = 1.5f
         });

         // We render any editor stuff from this bin.  Note that the HDR is
         // completed before this bin to keep editor elements from tone mapping.
         diffuseRenderPassManager.addManager(new RenderObjectMgr("EditorBin", true)
         {
            BinType = "Editor",
            RenderOrder = 1.6f,
            ProcessAddOrder = 1.6f
         });

         // Resolve format change token last.
         diffuseRenderPassManager.addManager(new RenderPassStateBin("FinalBin", true)
         {
            RenderOrder = 1.7f,
            StateToken = AL_FormatToken
         });
      }
   }
}