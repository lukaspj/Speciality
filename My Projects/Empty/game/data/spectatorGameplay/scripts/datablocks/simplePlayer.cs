datablock SimplePlayerData(SPD) {
  shapeFile = "data/spectatorGameplay/art/shapes/simplecone.dts";
  moveSpeed = 3;
};

function createSP() {
  new SimplePlayer(SP) {
    datablock = SPD;
    position = "0 0 1";
    ThinkFunction = "SPThink";
  };
}
