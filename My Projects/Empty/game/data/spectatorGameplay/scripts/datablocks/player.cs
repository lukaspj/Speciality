datablock PlayerData(BoxPlayer){
  shapeFile = "data/spectatorGameplay/art/GameShapes/player.dts";
  cameraMaxDist = 5;
  jumpDelay = 0;
};

singleton Material(PlayerMaterial){
  diffuseColor[0] = "1 0 0";
  mapTo = "PlayerTexture";
};
