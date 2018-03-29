using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textmove : MonoBehaviour {

	private float moveSpeed = 0.1f; //sets a var for move speed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-moveSpeed, 0, 0); //sets text to move
		
	}
}
