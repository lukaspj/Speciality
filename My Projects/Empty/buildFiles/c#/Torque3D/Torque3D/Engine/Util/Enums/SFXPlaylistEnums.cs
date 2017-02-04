namespace Torque3D.Util
{
   public enum SFXPlayListLoopMode
   {
      All,
      Single
   }

   public enum SFXPlayListRandomMode
   {
      NotRandom,
      StrictRandom,
      OrderedRandom
   }

   public enum SFXPlayListTransitionMode
   {
      None,
      Wait,
      WaitAll,
      Stop,
      StopAll
   }

   public enum SFXPlayListReplayMode
   {
      IgnorePlaying,
      RestartPlaying,
      KeepPlaying,
      StartNew,
      SkipIfPlaying
   }

   public enum SFXPlayListStateMode
   {
      StopInactive,
      PauseInactive,
      IgnoreInactive
   }
}
