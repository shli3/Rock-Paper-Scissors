using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour {

	public static int value = 0;
	public static int count = 1;
	public Text score;
	void Start () {
		score = GetComponent<Text>();
	}
	
	void Update () {
		score.text = "Score: " + value;
	}

	void Finale(){
		if(count == 10){
			if(value > 5){
				SceneManager.LoadScene("Victory");
			}
			else if(value < 5){
				SceneManager.LoadScene("Defeat");
			}
			else{
				SceneManager.LoadScene("Tie");
			}
		}
	}

}
