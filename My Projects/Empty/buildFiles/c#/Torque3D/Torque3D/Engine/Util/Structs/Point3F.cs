using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalPoint3FStruct
   {
      public float x;
      public float y;
      public float z;
   }

   public class Point3F
   {
      public float X { get; set; }
      public float Y { get; set; }
      public float Z { get; set; }
      public static Point3F Zero = new Point3F(0, 0, 0);

      public Point3F(float x, float y, float z)
      {
         X = x;
         Y = y;
         Z = z;
      }

      public Point3F(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 3) throw new ArgumentException("Point3F always takes exactly 3 parameters");
         X = float.Parse(split[0]);
         Y = float.Parse(split[1]);
         Z = float.Parse(split[2]);
      }

      public Point3F(float[] data)
      {
         if(data.Length != 3) throw new ArgumentException("Point3F always takes exactly 3 parameters");
         X = data[0];
         Y = data[1];
         Z = data[2];
      }

      internal Point3F(InternalPoint3FStruct point3FStruct)
      {
         X = point3FStruct.x;
         Y = point3FStruct.y;
         Z = point3FStruct.z;
      }

      public static Point3F operator +(Point3F p1, Point3F p2)
      {
         return new Point3F(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
      }

      public float[] ToArray()
      {
         return new[] {X,Y,Z};
      }

      internal InternalPoint3FStruct ToStruct()
      {
         return new InternalPoint3FStruct
         {
            x = X,
            y = Y,
            z = Z
         };
      }
   }

   public class VectorF : Point3F
   {
      public VectorF(float x, float y, float z) : base(x, y, z)
      {
      }

      public VectorF(float[] data) : base(data)
      {
      }

      public VectorF(string data) : base(data)
      {
      }

      internal VectorF(InternalPoint3FStruct point3FStruct) : base(point3FStruct)
      {
      }
   }
}
