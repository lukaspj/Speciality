using System;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Core.LightingSystem.Advanced
{
   class ShadowVizGui
   {
      public static void Init()
      {
         GuiControl AL_ShadowVizOverlayCtrl = new GuiControl("AL_ShadowVizOverlayCtrl")
         {
            CanSaveDynamicFields = false,
            IsContainer = true,
            Profile = Sim.FindObject<GuiControlProfile>("GuiModelessDialogProfile"),
            HorizSizing = GuiHorizontalSizing.Right,
            VertSizing = GuiVerticalSizing.Bottom,
            Position = new Point2I(0, 0),
            Extent = new Point2I(1024, 768),
            MinExtent = new Point2I(8, 8),
            CanSave = true,
            Visible = true,
            TooltipProfile = Sim.FindObject<GuiControlProfile>("GuiToolTipProfile"),
            Hovertime = 1000
         };
         AL_ShadowVizOverlayCtrl.setFieldValue("noCursor", "true");

         GuiWindowCtrl windowCtrl = new GuiWindowCtrl()
         {
            InternalName = "WindowCtrl",
            CanSaveDynamicFields = false,
            IsContainer = true,
            Profile = Sim.FindObject<GuiControlProfile>("GuiWindowProfile"),
            HorizSizing = GuiHorizontalSizing.Right,
            VertSizing = GuiVerticalSizing.Bottom,
            Position = new Point2I(50, 50),
            Extent = new Point2I(347, 209),
            MinExtent = new Point2I(150, 100),
            CanSave = true,
            Visible = true,
            TooltipProfile = Sim.FindObject<GuiControlProfile>("GuiToolTipProfile"),
            Hovertime = 1000,
            Margin = new RectSpacingI(0, 0, 0, 0),
            Padding = new RectSpacingI(0, 0, 0, 0),
            AnchorTop = true,
            AnchorBottom = false,
            AnchorLeft = true,
            AnchorRight = false,
            ResizeWidth = true,
            ResizeHeight = true,
            CanMove = true,
            CanClose = true,
            CanMinimize = false,
            CanMaximize = true,
            //todo minSize = "50 50"
            EdgeSnap = true,
            Text = "ShadowViz",
            CloseCommand = "toggleShadowViz();"
         };

         GuiMaterialCtrl materialCtrl = new GuiMaterialCtrl()
         {
            InternalName = "MatCtrl",
            CanSaveDynamicFields = false,
            IsContainer = false,
            Profile = Sim.FindObject<GuiControlProfile>("GuiDefaultProfile"),
            HorizSizing = GuiHorizontalSizing.Width,
            VertSizing = GuiVerticalSizing.Height,
            Position = new Point2I(3, 23),
            Extent = new Point2I(341, 181),
            MinExtent = new Point2I(8, 2),
            CanSave = true,
            Visible = true,
            TooltipProfile = Sim.FindObject<GuiControlProfile>("GuiToolTipProfile"),
            Hovertime = 1000,
            Docking = GuiDockingType.Client,
            Margin = new RectSpacingI(2, 2, 2, 2),
            Padding = new RectSpacingI(0, 0, 0, 0),
            AnchorTop = true,
            AnchorBottom = false,
            AnchorLeft = true,
            AnchorRight = false,
            MaterialName = "AL_ShadowVisualizeMaterial"
         };

         materialCtrl.registerObject();
         windowCtrl.addGuiControl(materialCtrl);
         windowCtrl.registerObject();
         AL_ShadowVizOverlayCtrl.addGuiControl(windowCtrl);
         AL_ShadowVizOverlayCtrl.registerObject();
      }
   }
}
