using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalRectIStruct
   {
      public int pointX;
      public int pointY;
      public int extentX;
      public int extentY;
   }

   public class RectI
   {
      public Point2I Point { get; set; }
      public Point2I Extent { get; set; }
      
      public RectI(int pointX, int pointY, int extentX, int extentY)
      {
         Point = new Point2I(pointX, pointY);
         Extent = new Point2I(extentX, extentY);
      }

      public RectI(string data)
      {
         int splitIdx = data.IndexOf(' ', data.IndexOf(' ') + 1);
         Point = new Point2I(data.Substring(0, splitIdx));
         Extent = new Point2I(data.Substring(splitIdx));
      }
      
      internal RectI(InternalRectIStruct point2IStruct)
      {
         Point = new Point2I(point2IStruct.pointX, point2IStruct.pointY);
         Extent = new Point2I(point2IStruct.extentX, point2IStruct.extentY);
      }

      internal InternalRectIStruct ToStruct()
      {
         return new InternalRectIStruct
         {
            pointX = Point.X,
            pointY = Point.Y,
            extentX = Extent.X,
            extentY = Extent.Y
         };
      }
   }
}
