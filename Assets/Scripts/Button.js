#pragma strict

public var isQuit = false;
public var isInfinite = false;
public var isFree = false;
public var isMenu = false;

function Start () {
	renderer.material.color = Color.grey;
}

function OnMouseEnter () {
	renderer.material.color = Color.white;
}

function OnMouseExit () {
	renderer.material.color = Color.grey;
}

function OnMouseUp () {
	if (isQuit == true) {
		Application.Quit();
	}
	else if (isInfinite == true) {
		Application.LoadLevel("GameInfinitePlay");
	}
	else if (isFree == true) {
		Application.LoadLevel("GameFreePlay");
	}
	else if (isMenu == true) {
		Application.LoadLevel("GameMenu");
	}
}