﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour {

	//leftover script from testing, left in to show my process, but disabled

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
		SceneManager.LoadScene ("gamecutscene1");
		}

	}
}