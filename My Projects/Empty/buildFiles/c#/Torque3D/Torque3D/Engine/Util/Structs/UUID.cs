using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   [StructLayout(LayoutKind.Sequential)]
   internal struct InternalUUIDStruct
   {
      public uint a;
      public ushort b;
      public ushort c;
      public char d;
      public char e;
      public char f1;
      public char f2;
      public char f3;
      public char f4;
      public char f5;
      public char f6;
   }

   public class UUID
   {
      public uint A { get; set; }
      public ushort B { get; set; }
      public ushort C { get; set; }
      public char D { get; set; }
      public char E { get; set; }
      public char[] F { get; set; }

      public UUID(uint a, ushort b, ushort c, char d, char e, char[] f)
      {
         A = a;
         B = b;
         C = c;
         D = d;
         E = e;
         F = f;
      }

      internal UUID(InternalUUIDStruct uuidStruct)
      {
         A = uuidStruct.a;
         B = uuidStruct.b;
         C = uuidStruct.c;
         D = uuidStruct.d;
         E = uuidStruct.e;
         F = new[]
         {
            uuidStruct.f1, uuidStruct.f2, uuidStruct.f3, uuidStruct.f4, uuidStruct.f5, uuidStruct.f6
         };
      }

      internal InternalUUIDStruct ToStruct()
      {
         return new InternalUUIDStruct
         {
            a = A,
            b = B,
            c = C,
            d = D,
            e = E,
            f1 = F[0],
            f2 = F[1],
            f3 = F[2],
            f4 = F[3],
            f5 = F[4],
            f6 = F[5]
         };
      }
   }
}
