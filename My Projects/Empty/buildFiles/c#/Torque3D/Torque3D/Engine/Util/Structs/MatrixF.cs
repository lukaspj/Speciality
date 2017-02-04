using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalMatrixFStruct
   {
      public float row1X;
      public float row1Y;
      public float row1Z;
      public float row1W;
      public float row2X;
      public float row2Y;
      public float row2Z;
      public float row2W;
      public float row3X;
      public float row3Y;
      public float row3Z;
      public float row3W;
      public float row4X;
      public float row4Y;
      public float row4Z;
      public float row4W;
   }

   public class MatrixF
   {
      public float[] M { get; set; }
      public static MatrixF Identity = new MatrixF(new []
      {
         1.0f, 0.0f, 0.0f, 0.0f,
         0.0f, 1.0f, 0.0f, 0.0f,
         0.0f, 0.0f, 1.0f, 0.0f,
         0.0f, 0.0f, 0.0f, 1.0f
      });

      public MatrixF(string data)
      {
         string[] split = data.Split(' ');
         if (split.Length != 16) throw new ArgumentException("MatrixF always takes exactly 16 parameters");
         M = new float[16];
         for (int index = 0; index < split.Length; index++)
         {
            string s = split[index];
            M[index] = float.Parse(s);
         }
      }

      public MatrixF(float[] data)
      {
         if(data.Length != 16) throw new ArgumentException("MatrixF always takes exactly 16 parameters");
         M = data;
      }

      internal MatrixF(InternalMatrixFStruct matrixFStruct)
      {
         M = new[]
         {
            matrixFStruct.row1X, matrixFStruct.row1Y, matrixFStruct.row1Z, matrixFStruct.row1W,
            matrixFStruct.row2X, matrixFStruct.row2Y, matrixFStruct.row2Z, matrixFStruct.row2W,
            matrixFStruct.row3X, matrixFStruct.row3Y, matrixFStruct.row3Z, matrixFStruct.row3W,
            matrixFStruct.row4X, matrixFStruct.row4Y, matrixFStruct.row4Z, matrixFStruct.row4W
         };
      }

      public float[] ToArray()
      {
         return M;
      }

      internal InternalMatrixFStruct ToStruct()
      {
         return new InternalMatrixFStruct
         {
            row1X = M[0], row1Y = M[1], row1Z = M[2], row1W = M[3],
            row2X = M[4], row2Y = M[5], row2Z = M[6], row2W = M[7],
            row3X = M[8], row3Y = M[9], row3Z = M[10], row3W = M[11],
            row4X = M[12], row4Y = M[13], row4Z = M[14], row4W = M[15]
         };
      }
   }
}
