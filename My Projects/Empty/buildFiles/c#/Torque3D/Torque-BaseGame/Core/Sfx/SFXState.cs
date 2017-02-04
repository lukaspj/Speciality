using Torque3D;

namespace Game.Core.Sfx
{
   [ConsoleClass]
   class SFXState : Torque3D.SFXState
   {
      public SFXState(string pName, bool pRegister = false) : base(pName, pRegister)
      {
      }

      public virtual void onActivate()
      {
         if(getId() != AudioStates.AudioStateNone.getId())
            AudioStates.AudioStateNone.disable();
      }

      public virtual void onDeactivate()
      {
         if(getId() != AudioStates.AudioStateNone.getId())
            AudioStates.AudioStateNone.enable();
      }
   }
}
