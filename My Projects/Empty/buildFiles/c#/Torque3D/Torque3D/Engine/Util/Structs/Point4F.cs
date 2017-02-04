using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalPoint4FStruct
   {
      public float x;
      public float y;
      public float z;
      public float w;
   }

   public class Point4F
   {
      public float X { get; set; }
      public float Y { get; set; }
      public float Z { get; set; }
      public float W { get; set; }
      public static Point4F Zero = new Point4F(0, 0, 0, 0);

      public Point4F(float x, float y, float z, float w)
      {
         X = x;
         Y = y;
         Z = z;
         W = w;
      }

      public Point4F(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 4) throw new ArgumentException("Point4F always takes exactly 4 parameters");
         X = float.Parse(split[0]);
         Y = float.Parse(split[1]);
         Z = float.Parse(split[2]);
         W = float.Parse(split[3]);
      }

      public Point4F(float[] data)
      {
         if(data.Length != 4) throw new ArgumentException("Point4F always takes exactly 4 parameters");
         X = data[0];
         Y = data[1];
         Z = data[2];
         W = data[3];
      }

      internal Point4F(InternalPoint4FStruct point4FStruct)
      {
         X = point4FStruct.x;
         Y = point4FStruct.y;
         Z = point4FStruct.z;
         W = point4FStruct.w;
      }

      public static Point4F operator +(Point4F p1, Point4F p2)
      {
         return new Point4F(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z, p1.W + p2.W);
      }

      public float[] ToArray()
      {
         return new[] {X,Y,Z, W};
      }

      internal InternalPoint4FStruct ToStruct()
      {
         return new InternalPoint4FStruct
         {
            x = X,
            y = Y,
            z = Z,
            w = W
         };
      }
   }
}
