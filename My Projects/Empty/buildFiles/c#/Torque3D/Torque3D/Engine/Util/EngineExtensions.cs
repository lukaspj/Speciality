using System;

namespace Torque3D.Engine.Util
{
   public static class EngineExtensions
   {
      public static string Tag(this String str)
      {
         return Global.addTaggedString(str);
      }
      public static string Detag(this String str)
      {
         return Global.detag(str);
      }

      public static string ColorEscape(this String str)
      {
         for (int i = 0; i < 10; i++)
         {
            str = str.Replace("\\c"+i, System.Text.Encoding.UTF8.GetString(new[] { Text.COLOR[i] }));
         }
         str = str.Replace("\\cp", System.Text.Encoding.UTF8.GetString(new[] { Text.COLOR_PUSH }));
         str = str.Replace("\\co", System.Text.Encoding.UTF8.GetString(new[] { Text.COLOR_POP }));
         str = str.Replace("\\cr", System.Text.Encoding.UTF8.GetString(new[] { Text.COLOR_RESET }));
         return str;
      }
   }
}
