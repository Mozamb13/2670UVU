using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Load : MonoBehaviour {

	public static Action EndButton;

	void Start(){
		Load.EndButton += EndThis;
	}

	private void EndThis(){
		GetComponent<Button>().interactable = false;
	}

	public string sceneName;

	// Use this for initialization
	public void Loadlevel(){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
		EndButton();
	}
		
	
}
