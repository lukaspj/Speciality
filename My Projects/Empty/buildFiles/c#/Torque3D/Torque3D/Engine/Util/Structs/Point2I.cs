using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalPoint2IStruct
   {
      public int x;
      public int y;
   }

   public class Point2I
   {
      public int X { get; set; }
      public int Y { get; set; }
      
      public Point2I(int x, int y)
      {
         X = x;
         Y = y;
      }

      public Point2I(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 2) throw new ArgumentException("Point2I always takes exactly 2 parameters");
         X = int.Parse(split[0]);
         Y = int.Parse(split[1]);
      }

      internal Point2I(int[] data)
      {
         if (data.Length != 2) throw new ArgumentException("Point2I always takes exactly 2 parameters");
         X = data[0];
         Y = data[1];
      }

      internal Point2I(InternalPoint2IStruct point2IStruct)
      {
         X = point2IStruct.x;
         Y = point2IStruct.y;
      }

      public static Point2I operator +(Point2I p1, Point2I p2)
      {
         return new Point2I(p1.X + p2.X, p1.Y + p2.Y);
      }

      public int[] ToArray()
      {
         return new[] {X,Y};
      }

      internal InternalPoint2IStruct ToStruct()
      {
         return new InternalPoint2IStruct
         {
            x = X,
            y = Y
         };
      }

      public override string ToString()
      {
         return $"{X} {Y}";
      }

      public static Point2I Zero = new Point2I(0, 0);
   }
}
