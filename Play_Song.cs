using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Song : MonoBehaviour {

	AudioSource audio;
	private int numberOfTimesPlayed;

	void Start () {
			audio = GetComponent<AudioSource> ();
			DontDestroyOnLoad (gameObject);

	}

}
