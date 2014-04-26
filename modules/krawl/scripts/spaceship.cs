function createSpaceShip()
{
	%spaceship = new Sprite(PlayerShip);
	%spaceship.setBodyType(dynamic);
	%spaceship.Position = "0 0";
	%spaceship.Size = "4 4";
	%spaceship.SceneLayer = 1;
	%spaceship.Image = "krawl:LoRez_SpaceShip";
	%spaceship.createPolygonBoxCollisionShape();
	%spaceship.setCollisionCallback(true);
	myScene.add(%spaceship);
}

function PlayerShip::onCollision(%this, %sceneobject, %collisiondetails)
{
	if(%sceneobject.getSceneGroup() == 20)
	{
		%explosion = new ParticlePlayer();
		%explosion.Particle = "ToyAssets:impactExplosion";
		%explosion.setPosition(%sceneobject.getPosition());
		%explosion.setSizeScale(2);
		myScene.add(%explosion);
		%sceneobject.safedelete();
		createAsteroids(1);
	}
}