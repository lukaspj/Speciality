using Game.Core.GfxData;
using Torque3D;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Advanced
{
   class DeferredShading
   {
      public static Torque3D.PostEffect AL_ColorBufferVisualize;
      public static Torque3D.PostEffect AL_SpecMapVisualize;
      public static Torque3D.PostEffect AL_DeferredShading;
      public static void Init()
      {
         new ShaderData("ClearGBufferShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/deferredClearGBufferP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/gl/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/deferredClearGBufferP.glsl",

            PixVersion = 2.0f
         }.registerSingleton();

         new ShaderData("DeferredColorShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/deferredColorShaderP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/gl/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/deferredColorShaderP.glsl",

            PixVersion = 2.0f
         }.registerSingleton();

         // Primary Deferred Shader
         GFXStateBlockData AL_DeferredShadingState = new GFXStateBlockData("AL_DeferredShadingState", "PFX_DefaultStateBlock")
         {
            CullMode = GFXCullMode.GFXCullNone,

            BlendDefined = true,
            BlendEnable = true,
            BlendSrc = GFXBlend.GFXBlendSrcAlpha,
            BlendDest = GFXBlend.GFXBlendInvSrcAlpha,

            SamplersDefined = true,
            SamplerStates = {
               [0] = CommonMaterialData.SamplerWrapLinear,
               [1] = CommonMaterialData.SamplerWrapLinear,
               [2] = CommonMaterialData.SamplerWrapLinear,
               [3] = CommonMaterialData.SamplerWrapLinear
            }
         };
         AL_DeferredShadingState.registerSingleton();

         new ShaderData("AL_DeferredShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/deferredShadingP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/gl/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/deferredShadingP.glsl",

            SamplerNames =
            {
               [0] = "colorBufferTex",
               [1] = "lightPrePassTex",
               [2] = "matInfoTex",
               [3] = "prepassTex"
            },

            PixVersion = 2.0f
         }.registerSingleton();

         AL_DeferredShading = new Torque3D.PostEffect("AL_DeferredShading")
         {
            RenderTime = PFXRenderTime.PFXAfterBin,
            RenderBin = "SkyBin",
            Shader = "AL_DeferredShader",
            StateBlock = AL_DeferredShadingState,
            Texture =
            {
               [0] = "#color",
               [1] = "#lightinfo",
               [2] = "#matinfo",
               [3] = "#prepass"
            },

            Target = "$backBuffer",
            RenderPriority = 10000,
            AllowReflectPass = true
         };
         AL_DeferredShading.registerSingleton();

         // Debug shaders
         new ShaderData("AL_ColorBufferShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgColorBufferP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/gl/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgColorBufferP.glsl",

            SamplerNames = {[0] = "colorBufferTex"},
            PixVersion = 2.0f
         }.registerSingleton();

         AL_ColorBufferVisualize = new Torque3D.PostEffect("AL_ColorBufferVisualize")
         {
            Shader = "AL_ColorBufferShader",
            StateBlock = LightViz.AL_DefaultVisualizeState,
            Texture = {[0] = "#color"},
            Target = "$backBuffer",
            RenderPriority = 9999
         };
         AL_ColorBufferVisualize.registerSingleton();

         // Debug shaders
         new ShaderData("AL_SpecMapShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgSpecMapVisualizeP.hlsl",

            OGLVertexShaderFile = "data/shaders/common/postFx/gl/postFxV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgSpecMapVisualizeP.glsl",

            SamplerNames = {[0] = "matinfoTex" },
            PixVersion = 2.0f
         }.registerSingleton();

         AL_SpecMapVisualize = new Torque3D.PostEffect("AL_SpecMapVisualize")
         {
            Shader = "AL_SpecMapShader",
            StateBlock = LightViz.AL_DefaultVisualizeState,
            Texture = {[0] = "#matinfo" },
            Target = "$backBuffer",
            RenderPriority = 9999
         };
         AL_SpecMapVisualize.registerSingleton();
      }

      /// <summary>
      /// Toggles the visualization of the AL lighting specular power buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleColorBufferViz(string enable)
      {
         if (string.IsNullOrEmpty(enable))
         {
            Globals.SetBool("AL_ColorBufferShaderVar", !AL_ColorBufferVisualize.IsEnabled);
            AL_ColorBufferVisualize.toggle();
         }
         else if (GenericMarshal.StringToBool(enable))
         {
            AL_DeferredShading.disable();
            AL_ColorBufferVisualize.enable();
         }
         else
         {
            AL_ColorBufferVisualize.disable();
            AL_DeferredShading.enable();
         }
      }

      /// <summary>
      /// Toggles the visualization of the AL lighting specular power buffer.
      /// </summary>
      /// <param name="enable"></param>
      [ConsoleFunction]
      public static void toggleSpecMapViz(string enable)
      {
         if (string.IsNullOrEmpty(enable))
         {
            Globals.SetBool("AL_SpecMapShaderVar", !AL_SpecMapVisualize.IsEnabled);
            AL_SpecMapVisualize.toggle();
         }
         else if (GenericMarshal.StringToBool(enable))
         {
            AL_DeferredShading.disable();
            AL_SpecMapVisualize.enable();
         }
         else
         {
            AL_SpecMapVisualize.disable();
            AL_DeferredShading.enable();
         }
      }
   }
}
