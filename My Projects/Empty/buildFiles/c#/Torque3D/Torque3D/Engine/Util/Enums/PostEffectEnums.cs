namespace Torque3D.Util
{
   public enum PFXRenderTime
   {
      PFXBeforeBin,
      PFXAfterBin,
      PFXAfterDiffuse,
      PFXEndOfFrame,
      PFXTexGenOnDenmand
   }

   public enum PFXTargetClear
   {
      PFXTargetClear_None,
      PFXTargetClear_OnCreate,
      PFXTargetClear_OnDraw
   }

   public enum PFXTargetViewport
   {
      PFXTargetViewport_TargetSize,
      PFXTargetViewport_GFXViewport,
      PFXTargetViewport_NamedInTexture0
   }
}
