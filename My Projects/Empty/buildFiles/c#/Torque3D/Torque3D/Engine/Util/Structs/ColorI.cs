using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalColorIStruct
   {
      public char r;
      public char g;
      public char b;
      public char a;
   }

   public class ColorI
   {
      public static readonly ColorI WHITE = new ColorI(255, 255, 255);
      public static readonly ColorI BLACK = new ColorI(0, 0, 0);

      public ColorI(char r, char g, char b, char a = (char) 255)
      {
         R = r;
         G = g;
         B = b;
         A = a;
      }

      public ColorI(int r, int g, int b, int a = 255)
      {
         R = (char) r;
         G = (char) g;
         B = (char) b;
         A = (char) a;
      }

      public ColorI(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 4) throw new ArgumentException("ColorI always expect 4 parameters");
         R = (char)int.Parse(split[0]);
         G = (char)int.Parse(split[1]);
         B = (char)int.Parse(split[2]);
         A = (char)int.Parse(split[3]);
      }

      public ColorI(char[] vals)
      {
         if (vals.Length != 4) throw new ArgumentException("ColorI always expect 4 parameters");
         R = vals[0];
         G = vals[1];
         B = vals[2];
         A = vals[3];
      }

      internal ColorI(InternalColorIStruct colorIStruct)
      {
         R = colorIStruct.r;
         G = colorIStruct.g;
         B = colorIStruct.b;
         A = colorIStruct.a;
      }

      public char R { get; set; }
      public char G { get; set; }
      public char B { get; set; }
      public char A { get; set; }

      public static ColorI operator +(ColorI c1, ColorI c2)
      {
         return new ColorI((char) (c1.R + c2.R), (char) (c1.G + c2.G), (char) (c1.B + c2.B), (char) (c1.A + c2.A));
      }

      public char[] ToArray()
      {
         return new[] {R, G, B, A};
      }

      public override string ToString()
      {
         return $"{(int)R} {(int)G} {(int)B} {(int)A}";
      }

      internal InternalColorIStruct ToStruct()
      {
         return new InternalColorIStruct
         {
            r = R,
            g = G,
            b = B,
            a = A
         };
      }
   }
}