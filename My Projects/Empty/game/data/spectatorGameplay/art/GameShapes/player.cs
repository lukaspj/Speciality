
singleton TSShapeConstructor(PlayerDts)
{
   baseShape = "./player.dts";
};

function PlayerDts::onLoad(%this)
{
   %this.addNode("Col-1", "", "0 0 0 0 0 1 0", "0");
   %this.addCollisionDetail("-1", "Box", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Box", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Sphere", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Box", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Sphere", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Capsule", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Capsule", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Capsule", "Cube", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Box", "Cube", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Box", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Sphere", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Capsule", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.addCollisionDetail("-1", "Box", "Bounds", "4", "30", "30", "32", "30", "30", "30");
   %this.setNodeTransform("Cube", "0 0 1 1 0 0 0", "0");
}
