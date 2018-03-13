using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyscript : MonoBehaviour {

	public GameObject tTxt;
	public GameObject tTxt3;
	public GameObject aTxt;
	public GameObject lTxt;
	public GameObject lTxt2;
	public GameObject sTxt;
	public GameObject hTxt;
	public GameObject oTxt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.S)){
			Destroy (tTxt);
			Destroy (tTxt3);
		}

		if (Input.GetKey (KeyCode.H)) {
			Destroy (aTxt);
		}

		if (Input.GetKey (KeyCode.S)) {
			Destroy (lTxt);
			Destroy (lTxt2);
		}

		if (Input.GetKey (KeyCode.T)) {
			Destroy (sTxt);
		}

		if (Input.GetKey (KeyCode.A)) {
			Destroy (hTxt);
		}

		if (Input.GetKey (KeyCode.L)) {
			Destroy (oTxt);
		}
	}
}
