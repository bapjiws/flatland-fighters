using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string name) {
		Debug.Log("LoadScene called for " + name);
		// Application.LoadLevel(name);
		SceneManager.LoadScene(name);
	}
}
