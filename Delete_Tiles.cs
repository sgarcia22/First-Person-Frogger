using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Tiles : MonoBehaviour {

	private GameObject tile;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		tile = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z >= (tile.transform.position.z + 10))
			Destroy (tile);
	}
}
