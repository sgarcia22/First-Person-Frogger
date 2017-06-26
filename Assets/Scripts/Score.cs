using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text score;
	static public int scoreAmount;
	// Use this for initialization
	void Start () {
		scoreAmount = 0;

	}
	
	// Update is called once per frame
	void Update () {
		score.text = scoreAmount.ToString();

	}
}
