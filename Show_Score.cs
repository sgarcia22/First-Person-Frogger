using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Score : MonoBehaviour {

	private int score;
	private string scoreToString;
	public Text scoreText;

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		scoreToString = score.ToString ();
		scoreText.text = "Score: " + scoreToString;
	}

}
