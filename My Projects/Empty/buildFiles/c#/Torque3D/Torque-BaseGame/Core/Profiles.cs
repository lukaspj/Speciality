using Torque3D;
using Torque3D.Util;

namespace Game.Core
{
   public class Profiles
   {
      public static void Init()
      {
         // Set font cache path if it doesn't already exist.
         if (string.IsNullOrEmpty(Globals.GetString("Gui::fontCacheDirectory")))
         {
            Globals.SetString("Gui::fontCacheDirectory", Global.expandFilename("sys/fonts"));
         }

         // ----------------------------------------------------------------------------
         // GuiDefaultProfile is a special profile that all other profiles inherit
         // defaults from. It must exist.
         // ----------------------------------------------------------------------------
         if (!Global.isObject("GuiDefaultProfile"))
         {
            GuiControlProfile guiDefaultProfile = new GuiControlProfile("GuiDefaultProfile")
            {
               Tab = false,
               CanKeyFocus = false,
               HasBitmapArray = false,
               MouseOverSelected = false,

               // fill color
               Opaque = false,
               FillColor = new ColorI(242, 241, 240),
               FillColorHL = new ColorI(228, 228, 235),
               FillColorSEL = new ColorI(98, 100, 137),
               FillColorNA = ColorI.WHITE,

               // border color
               Border = 0,
               BorderColor = new ColorI(100, 100, 100),
               BorderColorHL = new ColorI(50, 50, 50, 50),
               BorderColorNA = new ColorI(75, 75, 75),

               // font
               FontType = "Arial",
               FontSize = 14,
               FontCharset = GuiFontCharset.ANSI,

               FontColor = ColorI.BLACK,
               FontColorHL = ColorI.BLACK,
               FontColorNA = ColorI.BLACK,
               FontColorSEL = ColorI.WHITE,

               // bitmap information
               Bitmap = "",
               //TODO BitmapBase = "",
               TextOffset = new Point2I(0, 0),

               // used by guiTextControl
               Modal = true,
               Justify = GuiAlignmentType.Left,
               AutoSizeWidth = false,
               AutoSizeHeight = false,
               ReturnTab = false,
               NumbersOnly = false,
               CursorColor = ColorI.BLACK
            };
            guiDefaultProfile.registerObject();
         }

         if (!Global.isObject("GuiToolTipProfile"))
         {
            GuiControlProfile tooltipProfile = new GuiControlProfile("GuiToolTipProfile")
            {
               // fill color
               FillColor = new ColorI(239, 237, 222),

               // border color
               BorderColor = new ColorI(138, 134, 122),

               // font
               FontType = "Arial",
               FontSize = 14,
               FontColor = ColorI.BLACK,

               Category = "Core"
            };
            tooltipProfile.registerObject();
         }

         if (!Global.isObject("GuiWindowProfile"))
         {
            GuiControlProfile windowProfile = new GuiControlProfile("GuiWindowProfile")
            {
               Opaque = false,
               Border = 2,
               FillColor = new ColorI(242, 241, 240),
               FillColorHL = new ColorI(221, 221, 221),
               FillColorNA = new ColorI(200, 200, 200),
               FontColor = new ColorI(50, 50, 50),
               FontColorHL = ColorI.BLACK,
               BevelColorHL = ColorI.WHITE,
               BevelColorLL = ColorI.BLACK,
               //TODO: Text = "untitled",
               Bitmap = "core/images/window",
               TextOffset = new Point2I(8, 4),
               HasBitmapArray = true,
               Justify = GuiAlignmentType.Left,
               Category = "Core"
            };
            windowProfile.registerObject();
         }

         if (!Global.isObject("GuiTextEditProfile"))
         {
            GuiControlProfile textEditProfile = new GuiControlProfile("GuiTextEditProfile")
            {
               Opaque = true,
               Bitmap = "core/images/textEdit",
               HasBitmapArray = true,
               Border = -2,
               FillColor = new ColorI(242, 241, 240, 0),
               FillColorHL = ColorI.WHITE,
               FontColor = ColorI.BLACK,
               FontColorHL = ColorI.WHITE,
               FontColorSEL = new ColorI(98, 100, 137),
               FontColorNA = new ColorI(200, 200, 200),
               TextOffset = new Point2I(4, 2),
               AutoSizeWidth = false,
               AutoSizeHeight = true,
               Justify = GuiAlignmentType.Left,
               Tab = true,
               CanKeyFocus = true,
               Category = "Core"
            };
            textEditProfile.registerObject();
         }

         if (!Global.isObject("GuiScrollProfile"))
         {
            GuiControlProfile scrollProfile = new GuiControlProfile("GuiScrollProfile")
            {
               Opaque = true,
               FillColor = ColorI.WHITE,
               FontColor = ColorI.BLACK,
               FontColorHL = new ColorI(150, 150, 150),
               Border = 1,
               Bitmap = "core/images/scrollBar",
               HasBitmapArray = true,
               Category = "Core"
            };
            scrollProfile.registerObject();
         }

         if (!Global.isObject("GuiOverlayProfile"))
         {
            GuiControlProfile overlayProfile = new GuiControlProfile("GuiOverlayProfile")
            {
               Opaque = true,
               FillColor = ColorI.BLACK,
               FontColor = ColorI.BLACK,
               FontColorHL = ColorI.WHITE,
               Category = "Core"
            };
            overlayProfile.registerObject();
         }

         if (!Global.isObject("GuiCheckBoxProfile"))
         {
            GuiControlProfile checkBoxProfile = new GuiControlProfile("GuiCheckBoxProfile")
            {
               Opaque = false,
               FillColor = new ColorI(232, 232, 232),

               Border = 1,
               BorderColor = new ColorI(100, 100, 100),
               FontSize = 14,
               FontColor = new ColorI(20, 20, 20),
               FontColorHL = new ColorI(80, 80, 80),
               FontColorNA = new ColorI(200, 200, 200),

               //todo fixedExtent = true
               Justify = GuiAlignmentType.Left,
               Bitmap = "core/images/checkbox",
               HasBitmapArray = true,

               Category = "Tools" //todo why is it in core then?
            };
            checkBoxProfile.registerObject();
         }

         if (!Global.isObject("GuiProgressProfile"))
         {
            GuiControlProfile progressProfile = new GuiControlProfile("GuiProgressProfile")
            {
               Opaque = false,
               FillColor = new ColorI(0, 162, 255, 200),
               Border = 1,
               BorderColor = new ColorI(50, 50, 50, 200),
               Category = "Core"
            };
            progressProfile.registerObject();
         }

         if (!Global.isObject("GuiProgressBitmapProfile"))
         {
            GuiControlProfile progressBitmapProfile = new GuiControlProfile("GuiProgressBitmapProfile")
            {
               Opaque = false,
               HasBitmapArray = true,
               Bitmap = "core/images/loadingbar",
               Category = "Core"
            };
            progressBitmapProfile.registerObject();
         }

         if (!Global.isObject("GuiProgressTextProfile"))
         {
            GuiControlProfile progressTextProfile = new GuiControlProfile("GuiProgressTextProfile")
            {
               FontSize = 14,
               FontType = "Arial",
               FontColor = ColorI.BLACK,
               Justify = GuiAlignmentType.Center,
               Category = "Core"
            };
            progressTextProfile.registerObject();
         }

         if (!Global.isObject("GuiButtonProfile"))
         {
            GuiControlProfile buttonProfile = new GuiControlProfile("GuiButtonProfile")
            {
               Opaque = true,
               Border = 1,

               FontColor = new ColorI(50, 50, 50),
               FontColorHL = ColorI.BLACK,
               FontColorNA = new ColorI(200, 200, 200),
               //todo fixedExtent = false,
               Justify = GuiAlignmentType.Center,
               CanKeyFocus = false,
               Bitmap = "core/images/button",
               HasBitmapArray = false,
               Category = "Core"
            };
            buttonProfile.registerObject();
         }

         if (!Global.isObject("GuiModelessDialogProfile"))
         {
            GuiControlProfile modelessDialogProfile = new GuiControlProfile("GuiModelessDialogProfile")
            {
               Modal = false,
               Category = "Core"
            };
            modelessDialogProfile.registerObject();
         }
      }
   }
}