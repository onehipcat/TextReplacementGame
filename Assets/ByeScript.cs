using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class ByeScript : MonoBehaviour {

	string target = "hello";
	int index = 0;
	TextMesh textMesh;

	void Start () {
		textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if (index > target.Length) {
			return;
		}
		if (Input.GetKey (KeyCode.H)){
			CheckLetter ('h');
		}
		if (Input.GetKey (KeyCode.E)){
			CheckLetter ('e');
		}
		if (Input.GetKey (KeyCode.L)){
			CheckLetter ('l');
		}
		if (Input.GetKey (KeyCode.O)){
			CheckLetter ('o');
		}
	}

	void CheckLetter(char letter) {
		if (target[index] == letter) {
			StringBuilder sb = new StringBuilder(textMesh.text, target.Length);
			sb.Length = target.Length;
			sb[index] = letter;
			textMesh.text = sb.ToString();
			index++;
			Debug.Log (letter + " correctly pressed");
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.GetComponent<Healthandgameover> ()) {
			if (this.CheckCorrect() == false) {
				Healthandgameover.health -= 10;
				Debug.Log ("Health:" + Healthandgameover.health);
			}
		}
	}

	bool CheckCorrect() {
		return textMesh.text == target;
	}
}
