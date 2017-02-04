using Torque3D;
using Torque3D.Engine;

namespace Game.Core.Sfx
{
   class AudioAmbience
   {
      public static void Init()
      {
         new SFXAmbience("AudioAmbienceDefault")
         {
            Environment = AudioEnvironments.AudioEnvOff
         }.registerSingleton();

         new SFXAmbience("AudioAmbienceOutside")
         {
            Environment = AudioEnvironments.AudioEnvPlain,
            States = {[0] = AudioStates.AudioLocationOutside}
         }.registerSingleton();

         new SFXAmbience("AudioAmbienceInside")
         {
            Environment = AudioEnvironments.AudioEnvRoom,
            States = {[0] = AudioStates.AudioLocationInside}
         }.registerSingleton();

         new SFXAmbience("AudioAmbienceUnderwater")
         {
            Environment = AudioEnvironments.AudioEnvUnderwater,
            States = {[0] = AudioStates.AudioLocationUnderwater}
         }.registerSingleton();
      }
   }
}
