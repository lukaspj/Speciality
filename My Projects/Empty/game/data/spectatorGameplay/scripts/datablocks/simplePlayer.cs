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
  turnSpeed = 0.034906585;
  farDist = 100;



  cameraMaxDist = 5;
  variance = 1.0; // Actually stddev
  maxHealth = 20;
  Health = 20;
  damage = 1;
  killScore = 10;
  winningScore = 10;
};

datablock ParticleData(HitParticle : DefaultParticle)
{
   lifetimeMS = 1000;
   gravityCoefficient = 0;
   dragCoefficient = "2";

   sizes[0] = 1;
   sizes[1] = 1;
   sizes[2] = 1;
   sizes[3] = 1;
   inheritedVelFactor = "0";
};

datablock ParticleEmitterData(HitEmitter : DefaultEmitter)
{
   particles = HitParticle;

   ejectionPeriodMS = "10";
   ejectionVelocity = "4.167";
   ejectionOffset = "0.625";
   thetaMax = "180";
   softnessDistance = "1";
   lifetimeMS = "200";
};

datablock ParticleEmitterNodeData(HitNode)
{
   timeMultiple = 1.0;
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
