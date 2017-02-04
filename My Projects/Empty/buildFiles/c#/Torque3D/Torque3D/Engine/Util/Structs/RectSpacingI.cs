using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalRectSpacingIStruct
   {
      public float left;
      public float top;
      public float right;
      public float bottom;
   }

   public class RectSpacingI
   {
      public RectSpacingI(float left, float top, float right, float bottom)
      {
         Left = left;
         Top = top;
         Right = right;
         Bottom = bottom;
      }

      public RectSpacingI(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 4) throw new ArgumentException("RectSpacingI always takes exactly 4 parameters!");
         Left = float.Parse(split[0]);
         Top = float.Parse(split[1]);
         Right = float.Parse(split[2]);
         Bottom = float.Parse(split[3]);
      }

      internal RectSpacingI(InternalRectSpacingIStruct rectSpacingI)
      {
         Left = rectSpacingI.left;
         Top = rectSpacingI.top;
         Right = rectSpacingI.right;
         Bottom = rectSpacingI.bottom;
      }

      public float Left { get; set; }
      public float Top { get; set; }
      public float Right { get; set; }
      public float Bottom { get; set; }

      internal InternalRectSpacingIStruct ToStruct()
      {
         return new InternalRectSpacingIStruct
         {
            left = Left,
            top = Top,
            right = Right,
            bottom = Bottom
         };
      }
   }
}