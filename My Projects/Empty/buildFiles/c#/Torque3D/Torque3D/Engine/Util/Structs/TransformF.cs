using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalTransformFStruct
   {
      public float x;
      public float y;
      public float z;

      public float rx;
      public float ry;
      public float rz;
      public float ra;

      [MarshalAs(UnmanagedType.I1)]
      public bool hasRot;
   }

   public class TransformF
   {
      public Point3F Position { get; set; }
      public AngAxisF Orientation { get; set; }
      public bool HasRotation { get; set; }
      public static TransformF Identity = new TransformF(Point3F.Zero, new AngAxisF( new Point3F( 0, 0, 1 ), 0) );

      public TransformF(Point3F p, AngAxisF rotation)
      {
         Position = p;
         Orientation = rotation;
         HasRotation = true;
      }

      public TransformF(string data)
      {
         // TODO fix pls
         string[] split = data.Split(' ');
         if (split.Length != 7) throw new ArgumentException("TransformF always takes exactly 7 parameters");
         Position = new Point3F(float.Parse(split[0]), float.Parse(split[1]), float.Parse(split[2]));
         Orientation = new AngAxisF(float.Parse(split[3]), float.Parse(split[4]), float.Parse(split[5]), float.Parse(split[6]));
         HasRotation = true;
      }

      internal TransformF(InternalTransformFStruct internalTransformF)
      {
         Position = new Point3F(internalTransformF.x, internalTransformF.y, internalTransformF.z);
         Orientation = new AngAxisF(internalTransformF.rx, internalTransformF.ry, internalTransformF.rz, internalTransformF.ra);
         HasRotation = internalTransformF.hasRot;
      }

      internal InternalTransformFStruct ToStruct()
      {
         return new InternalTransformFStruct
         {
            x = Position.X,
            y = Position.Y,
            z = Position.Z,

            rx = Orientation.Axis.X,
            ry = Orientation.Axis.Y,
            rz = Orientation.Axis.Z,
            ra = Orientation.Angle,

            hasRot = HasRotation
         };
      }
   }
}
