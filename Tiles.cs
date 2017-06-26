using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour {

	public GameObject[] tiles; 
	public GameObject player;

	private GameObject currentTile;
	private GameObject tempGameObject;

	private Vector3 instantiatePosition;
	private Vector3 startPosition;

	private bool start = false;

	void Start () {
		
		player = GameObject.FindGameObjectWithTag ("Player");

		InvokeRepeating ("spawnTile", 0.1f, 0.5f);

		tempGameObject = tiles [0];

	}


	void Update () {

		currentTile = tiles[Random.Range(0, tiles.Length)];
		instantiatePosition.x = currentTile.transform.position.x;
		instantiatePosition.y = currentTile.transform.position.y;
		instantiatePosition.z = tempGameObject.transform.position.z + 12.5f;

		currentTile.transform.position = instantiatePosition;

	}

	private void spawnTile() {

		if (start == false) {

			startPosition.x = currentTile.transform.position.x;
			startPosition.y = currentTile.transform.position.y;
			startPosition.z = player.transform.position.z + 10;

			currentTile.transform.position = startPosition;

			tempGameObject = Instantiate (currentTile);

			start = true;

		} else {


			if (player.transform.position.z + 5 <= (currentTile.transform.position.z)) {

				if (!(currentTile.transform.position.z > player.transform.position.z + 100))
					tempGameObject = Instantiate (currentTile);	

			}
		}

		tempGameObject.transform.parent = gameObject.transform;
	}



}
