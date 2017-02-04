using Torque3D;

namespace Game.Core.Sfx
{
   /// <summary>
   /// Automatically deactivates sibling SFXStates in its parent SimGroup
   /// when activated.
   /// </summary>
   class AudioStateExclusive : SFXState
   {
      public AudioStateExclusive(string pName, bool pRegister = false) : base(pName, pRegister)
      {
      }

      public override void onActivate()
      {
         base.onActivate();

         SimGroup group = ParentGroup.As<SimGroup>();
         for (uint i = 0; i < group.getCount(); i++)
         {
            SimObject obj = group.getObject(i);

            if (obj.getId() == getId() || !obj.isMemberOfClass("SFXState")) continue;

            SFXState state = obj.As<SFXState>();
            if(state.isActive())
               state.deactivate();
         }
      }
   }
}
