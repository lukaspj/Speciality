namespace Torque3D.Util
{
   public enum SFXStatus
   {
      Null,
      Playing,
      Stopped,
      Paused,
      Blocked,
      Transition
   }

   public enum SFXDistanceModel
   {
      Linear,
      Logarithmic
   }

   public enum SFXChannel
   {
      Volume,
      Pitch,
      Priority,
      PositionX,
      PositionY,
      PositionZ,
      RotationX,
      RotationY,
      RotationZ,
      VelocityX,
      VelocityY,
      VelocityZ,
      ReferenceDistance,
      MaxDistance,
      ConeInsideAngle,
      ConeOutsideAngle,
      ConeOutsideVolume,
      Cursor,
      Status,
      User0,
      User1,
      User2,
      User3,
   }
}
