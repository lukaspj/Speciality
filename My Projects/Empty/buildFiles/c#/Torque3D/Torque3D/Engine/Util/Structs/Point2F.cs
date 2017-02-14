using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalPoint2FStruct
   {
      public float x;
      public float y;
   }

   public class Point2F
   {
      public float X { get; set; }
      public float Y { get; set; }
      
      public Point2F(float x, float y)
      {
         X = x;
         Y = y;
      }

      public Point2F(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 2) throw new ArgumentException("Point2F always takes exactly 2 parameters");
         X = float.Parse(split[0]);
         Y = float.Parse(split[1]);
      }
      
      internal Point2F(float[] data)
      {
         if(data.Length != 2) throw new ArgumentException("Point2F always takes exactly 2 parameters");
         X = data[0];
         Y = data[1];
      }
      
      internal Point2F(InternalPoint2FStruct point2FStruct)
      {
         X = point2FStruct.x;
         Y = point2FStruct.y;
      }
      /**
       * Distance from point p1 to p2
       * */
      public static double Distance(Point2F p1, Point2F p2)
      {
         return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
      }

      public static Point2F operator +(Point2F p1, Point2F p2)
      {
         return new Point2F(p1.X + p2.X, p1.Y + p2.Y);
      }

      public static Point2F operator *(Point2F p1, float coeff)
      {
         return new Point2F(p1.X * coeff, p1.Y * coeff);
      }

      public float[] ToArray()
      {
         return new[] {X,Y};
      }

      internal InternalPoint2FStruct ToStruct()
      {
         return new InternalPoint2FStruct
         {
            x = X,
            y = Y
         };
      }

      public static Point2F Zero = new Point2F(0, 0);

      public double GetDistanceToLine(Point2F start, Point2F end)
      {
         return Math.Abs((end.Y - start.Y) * X - (end.X - start.X) * Y + end.X * start.Y - end.Y * start.X) /
                Math.Sqrt((end.Y - start.Y) * (end.Y - start.Y) + (end.X - start.X) * (end.X - start.X));
      }
   }
}
