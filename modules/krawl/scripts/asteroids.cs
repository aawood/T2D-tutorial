function createAsteroids(%Number_of_Asteroids)
{
	for(%i=0;%i<%Number_of_Asteroids;%i++)
	{
		%asteroid = new Sprite();
		%asteroid.setBodyType(dynamic);
		%asteroid.Position = "-40" SPC getRandom(-35,35);
		%randomsize = getRandom(3,10);
		%asteroid.Size = %randomsize;
		%asteroid.SceneLayer = 1;
		%asteroid.createCircleCollisionShape( (%randomsize*0.85)/2);
		%asteroid.setDefaultRestitution(getRandom(0.5,1.1));
		%asteroid.setLinearVelocity(getRandom(15,35),0);
		%asteroid.setAngularVelocity(getRandom(5,25));
		%asteroid.SceneGroup = 20;
		%asteroid.Image = "ToyAssets:Asteroids";
		%asteroid.setImageFrame(getRandom(0,3));
		myScene.add(%asteroid);
	}
}