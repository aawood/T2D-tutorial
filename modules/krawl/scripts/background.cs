function createBackground()
{
	%background = new Sprite();
	%background.setBodyType(static);
	%background.Position = "0 0";
	%background.Size = "100 75";
	%background.SceneLayer = 31;
	%background.Image = "ToyAssets:skyBackground";
	%background.createEdgeCollisionShape(-50, -37.5, -50, 37.5);
	%background.createEdgeCollisionShape(50, -37.5, 50, 37.5);
	%background.createEdgeCollisionShape(-50, 37.5, 50, 37.5);
	%background.createEdgeCollisionShape(-50, -37.5, 50, -37.5);
	%background.setDefaultRestitution(1);
	myScene.add(%background);
}