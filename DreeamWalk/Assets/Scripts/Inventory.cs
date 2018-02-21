using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	void start()
	{
		InitializeInventory();
	}


	void InitializeInventory() // why is it not changing once i press "play"?
	{
		var slots = GameObject.Find("Slots");
		foreach(Transform slot in slots.transform)
		{
			slot.transform.GetChild(0).GetComponent<Image>().sprite = 
				Resources.Load<Sprite>("Inventory Items/empty_item");
		}
	}
}
