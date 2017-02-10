singleton Material(Red_PlayerMaterial) {
   diffuseColor[0] = "Red";
   mapTo = "red_PlayerTexture";
};

singleton Material(Blue_PlayerMaterial) {
   diffuseColor[0] = "Blue";
   mapTo = "blue_PlayerTexture";
};

singleton Material(DarkGreen_PlayerMaterial) {
   diffuseColor[0] = "DarkGreen";
   mapTo = "darkgreen_PlayerTexture";
};

singleton Material(Pink_PlayerMaterial) {
   diffuseColor[0] = "Pink";
   mapTo = "pink_PlayerTexture";
};

datablock SimplePlayerData(SPD) {
  shapeFile = "data/spectatorGameplay/art/GameShapes/player.dts";
  moveSpeed = 10;
  turnSpeed = 0.2;
  farDist = 100;



  cameraMaxDist = 5;
  variance = 0.2;
  maxHealth = 20;
  damage = 1;
  killScore = 10;
  respawnTime = 3000; //ms
  winningScore = 10;
};

function createSP() {
  new SimplePlayer(SP) {
    datablock = SPD;
    position = "2 2 1";
    ThinkFunction = "SPThink";
  };

  %availableSkins = "blue red darkgreen pink";

  %count = getWordCount(%availableSkins);
  %skin = getWord(%availableSkins, getRandom(%count) - 1 );
  echo("PlayerTexture=" @ %skin @ "_PlayerTexture");
  SP.setSkinName("PlayerTexture=" @ %skin @ "_PlayerTexture");
}
