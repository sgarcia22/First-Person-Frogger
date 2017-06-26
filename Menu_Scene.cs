using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Scene : MonoBehaviour {


	public void changeSceneToMenu () {
		Destroy (GameObject.FindGameObjectWithTag("Audio"));
		Application.LoadLevel (0);
	}

}
