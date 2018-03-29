using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

	private string CorrectAnswer;
	private string countGuess;



	[SerializeField]
	private InputField input;
	

	[SerializeField]
	private Text text;

	void Awake()
	{
		CorrectAnswer = "wakeup";
		text.text = "Enter the Code";  
	}

	public void GetInput(string guess)
	{
	
		input.text = "";
	}

	void CompareGuesses(string guess)
	{
		if (guess == CorrectAnswer)
		{
			text.text = "Where are you going to travel tomorrow?";
		} 
		// else ()
		// {
		// 	text.text = "Tik-Tok"
		// }
	}
}
