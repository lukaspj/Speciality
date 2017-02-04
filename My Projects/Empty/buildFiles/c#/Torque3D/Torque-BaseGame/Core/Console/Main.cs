using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Core.Console
{
   class Main
   {
      public static void Init()
      {
         Core.Console.Profiles.Init();
         Core.Console.Console.Init();
         ActionMap globalActionMap = Sim.FindObjectByName<ActionMap>("GlobalActionMap");

         globalActionMap.bindCmd("keyboard", "tilde", "toggleConsole(true);");
      }

      [ConsoleFunction]
      public static void toggleConsole(string make)
      {
         if (GenericMarshal.StringToBool(make))
         {
            if (Core.Console.Console.ConsoleDlg.isAwake())
            {
               // Deactivate the console
               Core.Canvas.GameCanvas.popDialog(Core.Console.Console.ConsoleDlg.Name);
            }
            else
            {
               Core.Canvas.GameCanvas.pushDialog(Core.Console.Console.ConsoleDlg.Name, 99);
            }
         }
      }
   }
}