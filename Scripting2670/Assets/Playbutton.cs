using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Playbutton : MonoBehaviour {

	public static Action Play;

	public void PushPlay () {
		Play();
	}

}
