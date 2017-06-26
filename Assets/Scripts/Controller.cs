using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	private GameObject player;

	public float mouseSensitivity = 200f;
	private float clampAngle = 80f;
	private float rotationX = 0f;
	private float rotationY = 0f;

	private float mouseX;
	private float mouseY;
	private Quaternion localRotation;

	void Start () {


		player = GameObject.FindGameObjectWithTag ("MainCamera");

		Vector3 rotationInitialize = transform.localRotation.eulerAngles;
		rotationX = rotationInitialize.x;
		rotationY = rotationInitialize.y;


	}	

	void Update () {

		mouseX = Input.GetAxis ("Mouse X");
		mouseY = -Input.GetAxis ("Mouse Y");

		rotationX += mouseX * mouseSensitivity * Time.deltaTime;
		rotationY += mouseY * mouseSensitivity * Time.deltaTime;

		rotationX = Mathf.Clamp (rotationX, -clampAngle, clampAngle);
		//TODO: Find out why rotation X & Y are switched 
		localRotation = Quaternion.Euler (rotationY, rotationX, 0.0f);

		player.transform.rotation = localRotation;

	}
}
