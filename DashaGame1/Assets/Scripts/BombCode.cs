using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCode : MonoBehaviour {

	//name input field
	public InputField nameField; 


	private string bombName;


	
	public void OnSubmit()
	{
		bombName = nameField.text;
		if (bombName.CompareTo("Hello") == 0) 
		{
		Debug.Log("You defused the bomb"); 
		}
	}


}
