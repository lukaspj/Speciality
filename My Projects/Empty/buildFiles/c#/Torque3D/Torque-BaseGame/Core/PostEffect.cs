using Game.Core.GfxData;
using Torque3D;

namespace Game.Core
{
   [ConsoleClass]
   public class PostEffect : Torque3D.PostEffect
   {
      // This is the Default PostFX state block. It is put here to so that we can use it
      // before we initialize the PostEffect system.
      private static GFXStateBlockData _defaultStateBlock;
      public static GFXStateBlockData PFX_DefaultStateBlock
      {
         get
         {
            if (_defaultStateBlock == null)
            {
               _defaultStateBlock = new GFXStateBlockData("PFX_DefaultStateBlock")
               {
                  ZDefined = true,
                  ZEnable = false,
                  ZWriteEnable = false,
                  SamplersDefined = true,
                  SamplerStates = { [0] = CommonMaterialData.SamplerClampLinear }
               };
               _defaultStateBlock.registerSingleton();
            }
            return _defaultStateBlock;
         }
      }

      public static void Init()
      {
         ShaderData PFX_PassthruShader = new ShaderData("PFX_PassthruShader")
         {
            DXVertexShaderFile = "data/shaders/common/postFx/postFxV.hlsl",
            DXPixelShaderFile = "data/shaders/common/postFx/passthruP.hlsl",

            //   OGLVertexShaderFile  = ""data/shaders/common/postFx/gl//postFxV.glsl"";
            //   OGLPixelShaderFile   = ""data/shaders/common/postFx/gl/passthruP.glsl"";

            SamplerNames = {[0] = "$inputTex"},
            PixVersion = 2.0f
         };
         PFX_PassthruShader.registerSingleton();
      }

      public void inspectVars()
      {
         string name = getName();
         string globals = $"${name}::*";
         //TODO inspectVars(globals);
      }

      public void viewDisassembly()
      {
         string file = dumpShaderDisassembly();

         if (string.IsNullOrEmpty(file))
         {
            Global.echo("PostEffect::viewDisassembly - no shader disassembly found.");
         }
         else
         {
            Global.echo($"PostEffect::viewDisassembly - shader disassembly file dumped ( {file} ).");
            Global.openFile(file);
         }
      }

      // Return true if we really want the effect enabled.
      // By default this is the case.
      public bool onEnabled()
      {
         return true;
      }
   }
}