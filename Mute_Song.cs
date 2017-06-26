using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute_Song : MonoBehaviour {

	public AudioSource audio;
	public Toggle toggle; 

	public void muteSong () {
		if (toggle.isOn) {
			audio.mute = true;
			audio.Stop ();
		} else {
			audio.mute = false;
			audio.Play();
		}
	}

}
