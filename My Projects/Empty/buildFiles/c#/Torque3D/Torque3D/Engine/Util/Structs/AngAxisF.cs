using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalAngAxisFStruct
   {
      public float pointX;
      public float pointY;
      public float pointZ;
      public float angle;
   }

   public class AngAxisF
   {
      public Point3F Axis { get; set; }
      public float Angle { get; set; }

      public AngAxisF(float x, float y, float z, float a)
      {
         Axis = new Point3F(x, y, z);
         Angle = a;
      }

      public AngAxisF(Point3F axis, float a)
      {
         Axis = axis;
         Angle = a;
      }

      internal AngAxisF(InternalAngAxisFStruct angAxisFStruct)
      {
         Axis = new Point3F(angAxisFStruct.pointX, angAxisFStruct.pointY, angAxisFStruct.pointZ);
         Angle = angAxisFStruct.angle;
      }

      public float[] ToArray()
      {
         return new[] {Axis.X, Axis.Y, Axis.Z, Angle};
      }

      internal InternalAngAxisFStruct ToStruct()
      {
         return new InternalAngAxisFStruct
         {
            pointX = Axis.X,
            pointY = Axis.Y,
            pointZ = Axis.Z,
            angle = Angle
         };
      }
   }
}
