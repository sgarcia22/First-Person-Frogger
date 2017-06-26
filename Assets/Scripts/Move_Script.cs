using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Script : MonoBehaviour {

	private GameObject player;
	private Rigidbody rb;

	private AudioSource audio;

	private Vector3 movement;
	private Animator animator;
	private bool down = false;

	public float moveBy = 10f;


	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		rb = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		movement = player.transform.position;
		//Increased Gravity
		rb.AddForce (Physics.gravity * 1.75f);

		if (player.transform.position.y <= -10) {
			PlayerPrefs.SetInt ("Score", Score.scoreAmount);
			Application.LoadLevel (2);
		
		}

		//Move the user with WSAD or Arrow keys
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			movement.z += moveBy * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			movement.z -= moveBy * Time.deltaTime;
		}	
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			movement.x -= moveBy * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			movement.x += moveBy * Time.deltaTime;
		}

		//TODO: Can press continuously
		if ((Input.GetKey(KeyCode.Space)) && down == false) {
			//Jump Function to where user is looking 
			down = true;
			audio.Play ();
			rb.velocity = new Vector3 (0f,12.5f,0f);


		}

		player.transform.position = movement;

	}

	void OnCollisionEnter (Collision collision) {
		down = false;
	}
		
	


}
