namespace Torque3D.Util
{
   public class Point3I
   {
      public int X { get; set; }
      public int Y { get; set; }
      public int Z { get; set; }

      public Point3I(int x, int y, int z)
      {
         X = x;
         Y = y;
         Z = z;
      }

      public static Point3I operator +(Point3I p1, Point3I p2)
      {
         return new Point3I(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
      }

      public int[] ToArray()
      {
         return new[] {X,Y,Z};
      }
   }
}
