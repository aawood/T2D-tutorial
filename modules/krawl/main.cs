function krawl::create( %this )
{
	exec("./gui/guiProfiles.cs");
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	exec("./scripts/background.cs");
	exec("./scripts/spaceship.cs");
	exec("./scripts/asteroids.cs");
	exec("./scripts/controls.cs");
	createSceneWindow();
	createScene();
	mySceneWindow.setScene(myScene);
	createBackground();
	createSpaceShip();
	createAsteroids(20);
	//myScene.setDebugOn("collision", "position", "aabb");
	new ScriptObject(InputManager);
	mySceneWindow.addInputListener(InputManager);
	InputManager.Init_controls();
}

function krawl::destroy( %this )
{
	shipcontrols.pop();
	destroySceneWindow();
	InputManager.delete();
}