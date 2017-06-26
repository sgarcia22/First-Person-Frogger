using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Has_Played : MonoBehaviour {

	private int numberOfTimesPlayed;

	//To set PlayerPrefs to 0 so that the program knows the user just opened the game
	void Start () {
		
	/*	numberOfTimesPlayed = PlayerPrefs.GetInt ("Playing", numberOfTimesPlayed);
		PlayerPrefs.SetInt ("Playing", numberOfTimesPlayed++);
		Debug.Log (numberOfTimesPlayed);*/
	}

}
 