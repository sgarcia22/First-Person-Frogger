using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Increase_Score : MonoBehaviour {

	private BoxCollider myCollider;

	private int count;

	void Start () {

		myCollider = GetComponent<BoxCollider> ();
		count = 0;

	}
	

	void OnCollisionEnter(Collision collision) {

		count++;

		if (count == 1) {
			Score.scoreAmount++;
		}

	}
}
