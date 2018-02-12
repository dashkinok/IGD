using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	private DisplayImage currentDisplay;
	private float initialCameraSize;
	private Vector3 initialCameraPosition;

void Start()
{
	currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
	initialCameraSize = Camera.main.orthographicSize;
	initialCameraPosition = Camera.main.transfor.positon;
}

public void onRightDoor()
{ 
	currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
}

public void onLeftDoor()
{
	currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
}


}
