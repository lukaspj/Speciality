using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalBox3FStruct
   {
      public float point1X;
      public float point1Y;
      public float point1Z;
      public float point2X;
      public float point2Y;
      public float point2Z;
   }

   public class Box3F
   {
      public Point3F MinExtents { get; set; }
      public Point3F MaxExtents { get; set; }

      public Box3F(float x1, float y1, float z1, float x2, float y2, float z2)
      {
         MinExtents = new Point3F(x1, y1, z1);
         MinExtents = new Point3F(x2, y2, z2);
      }

      public Box3F(float[] data)
      {
         if (data.Length != 6) throw new ArgumentException("Point2F always takes exactly 2 parameters");

         MinExtents = new Point3F(data[0], data[1], data[2]);
         MinExtents = new Point3F(data[4], data[5], data[6]);
      }

      internal Box3F(InternalBox3FStruct box3FStruct)
      {
         MinExtents = new Point3F(box3FStruct.point1X, box3FStruct.point1Y, box3FStruct.point1Z);
         MinExtents = new Point3F(box3FStruct.point2X, box3FStruct.point2Y, box3FStruct.point2Z);
      }

      public float[] ToArray()
      {
         return new[] {MinExtents.X, MinExtents.Y, MinExtents.Z, MaxExtents.X, MaxExtents.Y, MaxExtents.Z};
      }

      internal InternalBox3FStruct ToStruct()
      {
         return new InternalBox3FStruct
         {
            point1X = MinExtents.X,
            point1Y = MinExtents.Y,
            point1Z = MinExtents.Z,
            point2X = MaxExtents.X,
            point2Y = MaxExtents.Y,
            point2Z = MaxExtents.Z
         };
      }
   }
}
