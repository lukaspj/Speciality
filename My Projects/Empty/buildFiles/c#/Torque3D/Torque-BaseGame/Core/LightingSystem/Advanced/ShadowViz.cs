using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Advanced
{
   class ShadowViz
   {
      public static void Init()
      {
         ShaderData AL_ShadowVisualizeShader = new ShaderData("AL_ShadowVisualizeShader")
         {
            DXVertexShaderFile = "data/shaders/common/guiMaterialV.hlsl",
            DXPixelShaderFile = "data/shaders/common/lighting/advanced/dbgShadowVisualizeP.hlsl",
            OGLVertexShaderFile = "data/shaders/common/gl/guiMaterialV.glsl",
            OGLPixelShaderFile = "data/shaders/common/lighting/advanced/gl/dbgShadowVisualizeP.glsl",
            SamplerNames =
            {
               [0] = "$shadowMap",
               [1] = "$depthViz"
            },
            PixVersion = 2.0f
         };
         AL_ShadowVisualizeShader.registerSingleton();

         CustomMaterial AL_ShadowVisualizeMaterial = new CustomMaterial("AL_ShadowVisualizeMaterial")
         {
            Shader = "AL_ShadowVisualizeShader",
            StateBlock = AL_DepthVisualize.AL_DepthVisualizeState,
            //todo PixVersion = 2.0
         };
         AL_ShadowVisualizeMaterial.setFieldValue("sampler[shadowMap]", "#AL_ShadowVizTexture");
         AL_ShadowVisualizeMaterial.setFieldValue("sampler[depthViz]", "depthviz");
         AL_ShadowVisualizeMaterial.registerSingleton();

         GuiControlProfile AL_ShadowLabelTextProfile = new GuiControlProfile("AL_ShadowLabelTextProfile")
         {
            FontColor = ColorI.BLACK,
            AutoSizeWidth = true,
            AutoSizeHeight = true,
            Justify = GuiAlignmentType.Left,
            FontSize = 14,
         };
         AL_ShadowLabelTextProfile.registerSingleton();
      }

      /// <summary>
      /// Toggles the visualization of the pre-pass lighting buffer.
      /// </summary>
      [ConsoleFunction]
      public static void toggleShadowViz()
      {
         if (!Global.isObject("AL_ShadowVizOverlayCtrl")) return;
         GuiControl AL_ShadowVizOverlayCtrl = Sim.FindObject<GuiControl>("AL_ShadowVizOverlayCtrl");
         
         if (AL_ShadowVizOverlayCtrl.isAwake())
         {
            Global.setShadowVizLight("0");
            Canvas.GameCanvas.popDialog(AL_ShadowVizOverlayCtrl);
         }
         else
         {
            Canvas.GameCanvas.pushDialog("AL_ShadowVizOverlayCtrl", 100);
            if (!Global.isObject("EWorldEditor")) return;
            WorldEditor EWorldEditor = Sim.FindObject<WorldEditor>("EWorldEditor");
            _setShadowVizLight(EWorldEditor.getSelectedObject(0).ToString(), "false");
         }
      }

      /// <summary>
      /// Called from the WorldEditor when an object is selected.
      /// </summary>
      /// <param name="light"></param>
      /// <param name="force"></param>
      [ConsoleFunction]
      public static void _setShadowVizLight(string light, string force="false")
      {
         if (!Global.isObject("AL_ShadowVizOverlayCtrl")) return;
         GuiControl AL_ShadowVizOverlayCtrl = Sim.FindObject<GuiControl>("AL_ShadowVizOverlayCtrl");

         bool _force = GenericMarshal.StringToBool(force);

         if (!AL_ShadowVizOverlayCtrl.isAwake()) return;
         if (!GenericMarshal.StringToBool(AL_ShadowVizOverlayCtrl.getFieldValue("isLocked")) && !_force) return;

         string sizeAndAspect = null;

         // Resolve the object to the client side.
         if (Global.isObject("light"))
         {
            SimObject obj = Sim.FindObject<SimObject>(light);
            int clientLight = HelperFunctions.serverToClientObject(obj);
            sizeAndAspect = Global.setShadowVizLight(clientLight.ToString());
         }

         AL_ShadowVizOverlayCtrl.findObjectByInternalName("MatCtrl", true)
            .call("setMaterial", "AL_ShadowVisualizeMaterial");

         string text = "ShadowViz";
         if (Global.isObject(light))
            text += " : " + Global.getWord(sizeAndAspect, 0) + " x " + Global.getWord(sizeAndAspect, 1);

         AL_ShadowVizOverlayCtrl.findObjectByInternalName("WindowCtrl").As<GuiWindowCtrl>().Text = text;
      }

      /// <summary>
      /// For convenience, push the viz dialog and set the light manually from the console.
      /// </summary>
      /// <param name="light"></param>
      [ConsoleFunction]
      public static void showShadovVizForLight(string light)
      {
         if (!Global.isObject("AL_ShadowVizOverlayCtrl")) return;
         GuiControl AL_ShadowVizOverlayCtrl = Sim.FindObject<GuiControl>("AL_ShadowVizOverlayCtrl");
         if (!AL_ShadowVizOverlayCtrl.isAwake())
            Canvas.GameCanvas.pushDialog(AL_ShadowVizOverlayCtrl.Name, 100);
         _setShadowVizLight(light, "true");
      }

      /// <summary>
      /// Prevent shadowViz from changing lights in response to editor selection
      /// events until unlock is called. The only way a vis light will change while locked
      /// is if showShadowVizForLight is explicitly called by the user.
      /// </summary>
      [ConsoleFunction]
      public static void lockShadowViz()
      {
         if (!Global.isObject("AL_ShadowVizOverlayCtrl")) return;
         GuiControl AL_ShadowVizOverlayCtrl = Sim.FindObject<GuiControl>("AL_ShadowVizOverlayCtrl");
         AL_ShadowVizOverlayCtrl.setFieldValue("isLocked", "true");
      }

      [ConsoleFunction]
      public static void unlockShadowViz()
      {
         if (!Global.isObject("AL_ShadowVizOverlayCtrl")) return;
         GuiControl AL_ShadowVizOverlayCtrl = Sim.FindObject<GuiControl>("AL_ShadowVizOverlayCtrl");
         AL_ShadowVizOverlayCtrl.setFieldValue("isLocked", "false");
      }
   }
}