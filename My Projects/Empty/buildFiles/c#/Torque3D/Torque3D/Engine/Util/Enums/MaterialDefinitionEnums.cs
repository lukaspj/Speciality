namespace Torque3D.Util
{
   public enum MaterialAnimType
   {
      Scroll = 1,
      Rotate = 2,
      Wave = 4,
      Scale = 8,
      Sequence = 16
   }

   public enum MaterialBlendOp
   {
      None,
      Mul,
      Add,
      AddAlpha,
      Sub,
      LerpAlpha,
      ToneMap,
      NumBlendTypes
   }

   public enum MaterialWaveType
   {
      Sin,
      Triangle,
      Square
   }
}
