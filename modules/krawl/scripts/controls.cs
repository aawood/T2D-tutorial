function InputManager::onTouchDown(%this, %touchId, %worldposition)
{
	%picked = myScene.pickPoint(%worldposition);
	for (%i=0; %i < %picked.count; %i++)
	{
		%myobj = getWord(%picked,%i);
		if(%myobj.getSceneGroup() == 20)
		{
			%myobj.safedelete();
		}
	}
}

function InputManager::Init_controls(%this)
{
	new ActionMap(shipcontrols);
	shipcontrols.bindCmd(keyboard, "a", "PlayerShip.turnleft();", "PlayerShip.stopturn();");
	shipcontrols.bindCmd(keyboard, "d", "PlayerShip.turnright();", "PlayerShip.stopturn();");
	shipcontrols.bindCmd(keyboard, "w", "PlayerShip.accelerate();", "PlayerShip.stopthrust();");
	shipcontrols.push();

}