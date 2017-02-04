namespace Torque3D.Util
{
   public enum ShapeBaseImageLoadedState
   {
      IgnoreLoaded,
      Loaded,
      NotLoaded
   }

   public enum ShapeBaseImageSpinState
   {
      IgnoreSpin,
      NoSpin,
      SpinUp,
      SpinDown,
      FullSpin
   }

   public enum ShapeBaseImageRecoilState
   {
      NoRecoil,
      LightRecoil,
      MediumRecoil,
      HeavyRecoil
   }

   public enum ShapeBaseImageLightType
   {
      NoLight,
      ConstantLight,
      SpotLight,
      PulsingLight,
      WeaponFireLight
   }
}
