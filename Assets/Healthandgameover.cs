using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthandgameover : MonoBehaviour {
	public static int health = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if (health == 0) {
			//SceneManager.LoadScene ("gameoverscene");
		//}
		
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.GetComponent<textmove> ()) {
			health -= 10;
			Debug.Log ("Health:" + health);
		}
	}
		
}
