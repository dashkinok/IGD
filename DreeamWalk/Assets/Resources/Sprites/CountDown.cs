
using UnityEngine;
using System.Collections;
 
public class CountDown : MonoBehaviour {
	public float timeRemaining = 60f;
	// Use this for initialization
	void Start () {
 
	}
	
	void Update () {
		if (timeRemaining > 0) {
			Debug.Log("Waitting..."+timeRemaining);
			timeRemaining -= Time.deltaTime;
			if ( timeRemaining == 0 ) { GameOver(); }
			} 
	}
 
	void GameOver(){
 
	}
}