using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	public Text outcome;
	public Text opponentChoice;
	/*
	Rock 		= 	0
	Paper 		= 	1
	Scissors 	= 	2
	*/

	public void Rock(){
		//Random rng = new Random();
		int opponent = Random.Range(0, 3);
		System.Console.WriteLine("here");
		textChange(opponent, "Rock");
	}

	public void Paper(){
		//Random rng = new Random();
		int opponent = Random.Range(0, 3);
		textChange(opponent, "Paper");
	}

	public void Scissors(){
		//Random rng = new Random();
		int opponent = Random.Range(0, 3);
		textChange(opponent, "Scissors");
	}

	public void textChange(int r, string where){

		switch(where){
			case "Rock":
				if(r == 0){
					outcome.text = "Tie!";
					outcome.color = new Color(0f, 0f, 0f);
					opponentChoice.text = "CPU: Rock";
				}
				else if(r == 1){
					outcome.text = "Lose!";
					outcome.color = new Color(255f, 0f, 0f);
					opponentChoice.text = "CPU: Paper";
				}
				else{
					outcome.text = "Win!";
					outcome.color = new Color(0f, 255f, 0f);
					Scoreboard.value += 1;
					opponentChoice.text = "CPU: Scissors";
				}
				break;
			case "Paper":
				if(r == 0){
					outcome.text = "Win!";
					outcome.color = new Color(0f, 255f, 0f);
					Scoreboard.value += 1;
					opponentChoice.text = "CPU: Rock";
				}
				else if(r == 1){
					outcome.text = "Tie!";
					outcome.color = new Color(0f, 0f, 0f);
					opponentChoice.text = "CPU: Paper";
				}
				else{
					outcome.text = "Lose!";
					outcome.color = new Color(255f, 0f, 0f);
					opponentChoice.text = "CPU: Scissors";
				}
				break;
			case "Scissors":
				if(r == 0){
					outcome.text = "Lose!";
					outcome.color = new Color(255f, 0f, 0f);
					opponentChoice.text = "CPU: Rock";
				}
				else if(r == 1){
					outcome.text = "Win!";
					outcome.color = new Color(0f, 255f, 0f);
					Scoreboard.value += 1;
					opponentChoice.text = "CPU: Paper";
				}
				else{
					outcome.text = "Tie!";
					outcome.color = new Color(0f, 0f, 0f);
					opponentChoice.text = "CPU: Scissors";
				}
				break;
		}
		Scoreboard.count = Scoreboard.count + 1;
		if(Scoreboard.count == 11){
			Scoreboard.value = 0;
			Scoreboard.count = 0;
		}
	}

	
}
