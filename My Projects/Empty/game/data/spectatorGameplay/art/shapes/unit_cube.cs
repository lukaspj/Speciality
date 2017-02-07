
singleton TSShapeConstructor(Unit_cubeDts)
{
   baseShape = "./unit_cube.dts";
};

function Unit_cubeDts::onLoad(%this)
{
   %this.setNodeTransform("Cube", "0 0 0.560317 1 0 0 0", "1");
}
