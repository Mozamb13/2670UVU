using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	// Use this for initialization
	
	public Transform Startpoint;
	public GameObject art;
	public Animator anims;

	// Use this for initialization
	void Start () {
		endgame.End += ResetThis;
	}
	
	// Update is called once per frame
	void ResetThis() {
		art.SetActive(false);
		transform.position = Startpoint.position;
		Invoke("Restart", 3);
		
	}
	void Restart() {
		art.SetActive(true);
		anims.SetTrigger("IsLoaded");
		transform.position = Startpoint.position;
	}
}
