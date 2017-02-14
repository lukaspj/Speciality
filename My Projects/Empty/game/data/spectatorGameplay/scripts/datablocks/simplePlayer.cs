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

$SimplePlayerSkins = "blue darkgreen pink";

datablock SimplePlayerData(SPD) {
  shapeFile = "data/spectatorGameplay/art/GameShapes/player.dts";
  moveSpeed = 10;
  turnSpeed = 0.02;
  farDist = 100;



  cameraMaxDist = 5;
  variance = 1.0;
  maxHealth = 20;
  Health = 20;
  damage = 1;
  killScore = 10;
  respawnTime = 3000; //ms
  winningScore = 10;
  maxDamage = 300;
};

function createSP() {
  new SimplePlayer(SP) {
    datablock = SPD;
    position = "2 2 1";
    ThinkFunction = "SPThink";
  };

  %count = getWordCount($SimplePlayerSkins);
  %skin = getWord($SimplePlayerSkins, getRandom(%count) - 1 );
  echo("PlayerTexture=" @ %skin @ "_PlayerTexture");
  SP.setSkinName("PlayerTexture=" @ %skin @ "_PlayerTexture");
}
