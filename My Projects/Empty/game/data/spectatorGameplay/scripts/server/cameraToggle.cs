function serverCmdToggleCamera(%client)
{
   if (%client.getControlObject() == %client.player)
   {
      %client.camera.setVelocity("0 0 0");
      %control = %client.camera;
   }
   else
   {
      %client.player.setVelocity("0 0 0");
      %control = %client.player;
   }
   %client.setControlObject(%control);
}

function serverCmdadjustCamera(%client, %adjustment)
{
   if(%client.camera.controlMode $= "OrbitObject")
   {
      if(%adjustment == 1)
         %n = %client.camera.camDist + 0.5;
      else
         %n = %client.camera.camDist - 0.5;

      if(%n < 0.5)
         %n = 0.5;

      if(%n > 15)
         %n = 15.0;

      %client.camera.setOrbitObject(%client.player, %client.camera.getRotation(),
        0, %n, %n);
      %client.camera.camDist = %n;
   }
   if(%client.camera.controlMode $= "Overhead")
   {
      %client.camera.setVelocity("0 0" SPC %adjustment);
   }
}
