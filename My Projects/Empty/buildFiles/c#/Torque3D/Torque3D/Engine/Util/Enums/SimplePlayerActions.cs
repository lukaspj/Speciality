namespace Torque3D.Engine.Util.Enums
{
   public enum PlayerAction
   {
      /// <summary>
      /// Take no action, you damned camper.
      /// </summary>
      None,
      /// <summary>
      /// Strafe left.
      /// </summary>
      MoveLeft,
      /// <summary>
      /// Strafe right.
      /// </summary>
      MoveRight,
      /// <summary>
      /// Move the character forwards.
      /// </summary>
      MoveForward,
      /// <summary>
      /// Move the character backwards.
      /// </summary>
      MoveBackward,
      /// <summary>
      /// Turns right at a rate of 2 degrees per tick. This will increase the rotation value.
      /// </summary>
      TurnRight,
      /// <summary>
      /// Turns left at a rate of 2 degrees per tick. This will decrease the rotation value.
      /// </summary>
      TurnLeft,
      /// <summary>
      /// Shoot once, with a probability of missing. If the shoot delay is "active" (i.e. not at 0) then this action will fail.
      /// </summary>
      Shoot,
      /// <summary>
      /// Save one action for next round.
      /// </summary>
      Prepare
   };
}
