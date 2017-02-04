using Torque3D;
using Torque3D.Engine;

namespace Game.Core.Sfx
{
   class AudioDescriptions
   {
      public static void Init()
      {
         // Always declare SFXDescription's (the type of sound) before SFXProfile's (the
         // sound itself) when creating new ones

         //-----------------------------------------------------------------------------
         // 3D Sounds
         //-----------------------------------------------------------------------------

         //-----------------------------------------------------------------------------
         // Single shot sounds
         //-----------------------------------------------------------------------------

         new SFXDescription("AudioDefault3D", "AudioEffect")
         {
            Is3D = true,
            ReferenceDistance = 20.0f,
            MaxDistance = 100.0f
         }.registerSingleton();

         new SFXDescription("AudioSoft3D", "AudioEffect")
         {
            Is3D = true,
            ReferenceDistance = 20.0f,
            MaxDistance = 100.0f,
            Volume = 0.4f
         }.registerSingleton();

         new SFXDescription("AudioClose3D", "AudioEffect")
         {
            Is3D = true,
            ReferenceDistance = 10.0f,
            MaxDistance = 60.0f
         }.registerSingleton();

         new SFXDescription("AudioClosest3D", "AudioEffect")
         {
            Is3D = true,
            ReferenceDistance = 5.0f,
            MaxDistance = 10.0f
         }.registerSingleton();

         //-----------------------------------------------------------------------------
         // Looping sounds
         //-----------------------------------------------------------------------------

         new SFXDescription("AudioDefaultLoop3D", "AudioEffect")
         {
            IsLooping = true,
            Is3D = true,
            ReferenceDistance = 20.0f,
            MaxDistance = 100.0f
         }.registerSingleton();

         new SFXDescription("AudioCloseLoop3D", "AudioEffect")
         {
            IsLooping = true,
            Is3D = true,
            ReferenceDistance = 18.0f,
            MaxDistance = 25.0f
         }.registerSingleton();

         new SFXDescription("AudioClosestLoop3D", "AudioEffect")
         {
            IsLooping = true,
            Is3D = true,
            ReferenceDistance = 5.0f,
            MaxDistance = 10.0f
         }.registerSingleton();

         //-----------------------------------------------------------------------------
         // 2D sounds
         //-----------------------------------------------------------------------------

         // Used for non-looping environmental sounds (like power on, power off)
         new SFXDescription("Audio2D", "AudioEffect")
         {
            IsLooping = false,
         }.registerSingleton();

         // Used for Looping Environmental Sounds
         new SFXDescription("AudioLoop2D", "AudioEffect")
         {
            IsLooping = true,
         }.registerSingleton();
         
         new SFXDescription("AudioStream2D", "AudioEffect")
         {
            IsStreaming = true
         }.registerSingleton();
         
         new SFXDescription("AudioStreamLoop2D", "AudioEffect")
         {
            IsLooping = true,
            IsStreaming = true
         }.registerSingleton();

         //-----------------------------------------------------------------------------
         // Music
         //-----------------------------------------------------------------------------

         new SFXDescription("AudioMusic2D", "AudioEffect")
         {
            IsStreaming = true
         }.registerSingleton();

         new SFXDescription("AudioMusicLoop2D", "AudioEffect")
         {
            IsLooping = true,
            IsStreaming = true
         }.registerSingleton();

         new SFXDescription("AudioMusic3D", "AudioEffect")
         {
            IsStreaming = true,
            Is3D = true
         }.registerSingleton();

         new SFXDescription("AudioMusicLoop3D", "AudioEffect")
         {
            IsStreaming = true,
            Is3D = true,
            IsLooping = true
         }.registerSingleton();
      }
   }
}
