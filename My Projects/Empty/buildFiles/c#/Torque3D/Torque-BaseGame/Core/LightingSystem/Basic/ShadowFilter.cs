using Torque3D;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Basic
{
   class ShadowFilter
   {
      public static void Init()
      {
         ShaderData ShadowFilterShaderV = new ShaderData("BL_ShadowFilterShaderV")
         {
            DXVertexShaderFile = "data/shaders/common/lighting/basic/shadowFilterV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/basic/shadowFilterP.hlsl",
            OGLVertexShaderFile = "data/shaders/common/lighting/basic/gl/shadowFilterV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/basic/gl/shadowFilterP.glsl",
            SamplerNames = {[0] = "$diffuseMap"},
            Defines = "BLUR_DIR=float2(1.0,0.0)",
            PixVersion = 2.0f
         };
         ShadowFilterShaderV.registerSingleton();

         new ShaderData("BL_ShadowFilterShaderH", ShadowFilterShaderV)
         {
            Defines = "BLUR_DIR=float2(0.0,1.0)"
         }.registerSingleton();


         GFXStateBlockData BL_ShadowFilterSB = new GFXStateBlockData("BL_ShadowFilterSB", Core.PostEffect.PFX_DefaultStateBlock)
         {
            ColorWriteDefined = true,
            ColorWriteRed = false,
            ColorWriteGreen = false,
            ColorWriteBlue = false,
            BlendDefined = true,
            BlendEnable = true
         };
         BL_ShadowFilterSB.registerSingleton();

         // NOTE: This is ONLY used in Basic Lighting, and 
         // only directly by the ProjectedShadow.  It is not 
         // meant to be manually enabled like other PostEffects.
         Torque3D.PostEffect BL_ShadowFilterPostFx = new Torque3D.PostEffect("BL_ShadowFilterPostFx")
         {
            // Blur vertically
            Shader = "BL_ShadowFilterShaderV",
            StateBlock = PostEffect.PFX_DefaultStateBlock,
            TargetClear = PFXTargetClear.PFXTargetClear_OnDraw,
            TargetClearColor = new ColorF(0.0f, 0.0f, 0.0f, 0.0f),
            Texture = {[0] = "$inTex"},
            Target = "$outTex"
         };

         Torque3D.PostEffect blurEffect = new Torque3D.PostEffect
         {
            Shader = "BL_ShadowFilterShaderH",
            StateBlock = PostEffect.PFX_DefaultStateBlock,
            Texture = {[0] = "$inTex"},
            Target = "$outTex"
         };
         blurEffect.registerObject();
         BL_ShadowFilterPostFx.add(blurEffect);

         BL_ShadowFilterPostFx.registerObject();
      }
   }
}