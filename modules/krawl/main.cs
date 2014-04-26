function krawl::create( %this )
{
	exec("./gui/guiProfiles.cs");
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	exec("./scripts/background.cs");
	exec("./scripts/spaceship.cs");
	exec("./scripts/asteroids.cs");
	createSceneWindow();
	createScene();
	mySceneWindow.setScene(myScene);
	createBackground();
	createSpaceShip();
	createAsteroids(20);
	//myScene.setDebugOn("collision", "position", "aabb");
}

function krawl::destroy( %this )
{
	destroySceneWindow();
}