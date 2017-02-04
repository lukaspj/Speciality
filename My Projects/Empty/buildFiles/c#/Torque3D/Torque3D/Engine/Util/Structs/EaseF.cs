using System;
using System.Runtime.InteropServices;

namespace Torque3D.Util
{
   public class EaseF
   {
      [StructLayout(LayoutKind.Sequential)]
      internal struct InternalEaseFStruct
      {
         public int dir;
         public int type;
         public float param1;
         public float param2;
      }

      public int Direction { get; set; }
      public int Type { get; set; }
      public float Param1 { get; set; }
      public float Param2 { get; set; }

      public EaseF(int dir, int type, float param1, float param2)
      {
         Direction = dir;
         Type = type;
         Param1 = param1;
         Param2 = param2;
      }

      public EaseF(string data)
      {
         string[] split = data.Split(' ');
         if(split.Length != 4) throw new ArgumentException("EaseF always takes exactly 4 parameters!");
         Direction = int.Parse(split[0]);
         Type = int.Parse(split[1]);
         Param1 = float.Parse(split[2]);
         Param2 = float.Parse(split[3]);
      }

      internal InternalEaseFStruct ToStruct()
      {
         return new InternalEaseFStruct
         {
            dir = Direction,
            type = Type,
            param1 = Param1,
            param2 = Param2
         };
      }
   }
}
