using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{

//  public Text scoreText;
 
// 	void Start () {
// 		InvokeRepeating("RunTimer", 1, 1);
// 	}
 
// 	void RunTimer() {
// 		scoreText.text = (int.Parse(scoreText.text) - 1).ToString();
// 	}
// }


public float myTimer = 120;
    public Text timerText;
    private bool timerIsActive = true;

    void Start () {
        timerText = GetComponent<Text> ();
    }

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update () {
        if (timerIsActive) {
            myTimer -= Time.deltaTime;
            timerText.text = myTimer.ToString ("f0");
            print (myTimer);

            if (myTimer <= 0) {
                myTimer = 0;
                timerIsActive = false;
                

            }
        }

    }
}


