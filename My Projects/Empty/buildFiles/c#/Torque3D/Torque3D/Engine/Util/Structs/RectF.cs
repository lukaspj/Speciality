using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalRectFStruct
   {
      public float pointX;
      public float pointY;
      public float extentX;
      public float extentY;
   }

   public class RectF
   {
      public Point2F Point { get; set; }
      public Point2F Extent { get; set; }
      
      public RectF(float pointX, float pointY, float extentX, float extentY)
      {
         Point = new Point2F(pointX, pointY);
         Extent = new Point2F(extentX, extentY);
      }
      
      internal RectF(InternalRectFStruct point2FStruct)
      {
         Point = new Point2F(point2FStruct.pointX, point2FStruct.pointY);
         Extent = new Point2F(point2FStruct.extentX, point2FStruct.extentY);
      }

      public RectF(string data)
      {
         int splitIdx = data.IndexOf(' ', data.IndexOf(' ') + 1);
         Point = new Point2F(data.Substring(0, splitIdx));
         Extent = new Point2F(data.Substring(splitIdx));
      }

      internal InternalRectFStruct ToStruct()
      {
         return new InternalRectFStruct
         {
            pointX = Point.X,
            pointY = Point.Y,
            extentX = Extent.X,
            extentY = Extent.Y
         };
      }
   }
}
