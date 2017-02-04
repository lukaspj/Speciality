using Torque3D;
using Torque3D.Engine;

namespace Game.Core.Sfx
{
   class AudioData
   {
      public static void Init()
      {
         // Game specific audio descriptions. Always declare SFXDescription's (the type of sound)
         // before SFXProfile's (the sound itself) when creating new ones

         new SFXDescription("BulletFireDesc", "AudioEffect")
         {
            IsLooping = false,
            Is3D = true,
            ReferenceDistance = 10.0f,
            MaxDistance = 60.0f
         }.registerSingleton();

         new SFXDescription("BulletImpactDesc", "AudioEffect")
         {
            IsLooping = false,
            Is3D = true,
            ReferenceDistance = 10.0f,
            MaxDistance = 30.0f,
            Volume = 0.4f,
            Pitch = 1.4f
         }.registerSingleton();
      }
   }
}
