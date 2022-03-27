﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger_LoadScene : MonoBehaviour {
	[SerializeField] private string sceneName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider user){
		if (user.tag == "Player") {
			SceneManager.LoadScene(sceneName);
		}
	}
}
