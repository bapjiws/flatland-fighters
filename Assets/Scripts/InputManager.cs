using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {
	public Text currentInput;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && currentInput != null) {
			Debug.Log("SPACE is pressed!");
			currentInput.text = "SPACE IS PRESSED RIGHT FUCKING NOW! HOW COOL IS THAT?";
		} else if (Input.GetKeyDown(KeyCode.DownArrow) && currentInput != null) {
			Debug.Log("DOWN is pressed!");
			currentInput.text = "DOWN WILL BE SHOWN TO YOU! YAY!";
		}
	}
}
