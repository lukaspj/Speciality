datablock PlayerData(BoxPlayer){
  shapeFile = "data/spectatorGameplay/art/GameShapes/player.dts";
  cameraMaxDist = 5;
  jumpDelay = 0;
  variance = 0.2;
  maxHealth = 20;
  damage = 1;
  killScore = 10;
  respawnTime = 3000; //ms
  winningScore = 10;
};

singleton Material(PlayerMaterial){
  diffuseColor[0] = "1 0 0";
  mapTo = "PlayerTexture";
};
