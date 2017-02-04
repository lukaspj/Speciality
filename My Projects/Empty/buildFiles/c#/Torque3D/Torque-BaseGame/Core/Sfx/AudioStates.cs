using Torque3D;
using Torque3D.Engine;

namespace Game.Core.Sfx
{
   class AudioStates
   {
      public static SFXState AudioStateNone;

      public static SimGroup AudioLocation;
      public static SFXState AudioLocationOutside;
      public static SFXState AudioLocationUnderwater;
      public static SFXState AudioLocationInside;

      public static SimGroup AudioMood;
      public static SFXState AudioMoodNeutral;
      public static SFXState AudioMoodAggressive;
      public static SFXState AudioMoodTense;
      public static SFXState AudioMoodVictory;
      public static SFXState AudioMoodCalm;
      public static void Init()
      {
         //-----------------------------------------------------------------------------
         // Special audio state that will always and only be active when no other
         // state is active.  Useful for letting slots apply specifically when no
         // other slot in a list applies.
         AudioStateNone = new SFXState("AudioStateNone");
         AudioStateNone.registerSingleton();
         AudioStateNone.activate();

         //-----------------------------------------------------------------------------
         // Location-dependent states.

         AudioLocation = new SimGroup("AudioLocation", true);

         // State when the listener is outside.
         AudioLocationOutside = new AudioStateExclusive("AudioLocationOutside")
         {
            ParentGroup = AudioLocation
         };
         AudioLocationOutside.registerSingleton();

         // State when the listener is submerged.
         AudioLocationUnderwater = new AudioStateExclusive("AudioLocationUnderwater")
         {
            ParentGroup = AudioLocation
         };
         AudioLocationUnderwater.registerSingleton();

         // State when the listener is indoors.
         AudioLocationInside = new AudioStateExclusive("AudioLocationInside")
         {
            ParentGroup = AudioLocation
         };
         AudioLocationInside.registerSingleton();

         //-----------------------------------------------------------------------------
         // Mood-dependent states.

         AudioMood = new SimGroup("AudioMood", true);

         AudioMoodNeutral = new AudioStateExclusive("AudioMoodNeutral")
         {
            ParentGroup = AudioMood
         };
         AudioMoodNeutral.registerSingleton();

         AudioMoodAggressive = new AudioStateExclusive("AudioMoodAggressive")
         {
            ParentGroup = AudioMood
         };
         AudioMoodAggressive.registerSingleton();

         AudioMoodTense = new AudioStateExclusive("AudioMoodTense")
         {
            ParentGroup = AudioMood
         };
         AudioMoodTense.registerSingleton();

         AudioMoodVictory = new AudioStateExclusive("AudioMoodVictory")
         {
            ParentGroup = AudioMood
         };
         AudioMoodVictory.registerSingleton();

         AudioMoodCalm = new AudioStateExclusive("AudioMoodCalm")
         {
            ParentGroup = AudioMood
         };
         AudioMoodCalm.registerSingleton();
      }

      /// <summary>
      /// Return the first active SFXState in the given SimSet/SimGroup.
      /// </summary>
      /// <param name="group"></param>
      public static SFXState sfxGetActiveStateInGroup(SimGroup group)
      {
         for (uint i = 0; i < group.getCount(); i++)
         {
            SimObject obj = group.getObject(i);
            if (!obj.isMemberOfClass("SFXState")) continue;

            SFXState state = obj.As<SFXState>();
            if (state.isActive()) return state;
         }

         return null;
      }

      /// <summary>
      /// Return the currently active SFXState in AudioLocation.
      /// </summary>
      /// <returns></returns>
      public static SFXState sfxGetLocation()
      {
         return sfxGetActiveStateInGroup(AudioLocation);
      }

      /// <summary>
      /// Return the currently active SFXState in AudioMood.
      /// </summary>
      /// <returns></returns>
      public static SFXState sfxGetMood()
      {
         return sfxGetActiveStateInGroup(AudioMood);
      }
   }
}
