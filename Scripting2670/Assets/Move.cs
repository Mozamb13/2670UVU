using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move : MonoBehaviour {

	Action KeyAction;


	// Use this for initialization
	private void Start () {
		KeyAction = Moves;
	}
	
	void Moves() {
		print("LeftArrow");
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			KeyAction();
		}
	}
}
