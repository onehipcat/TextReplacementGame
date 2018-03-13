using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class ByeScript : MonoBehaviour {

	string target = "hello";
	int index = 0;
	bool active = false;
	TextMesh textMesh;

	void Start () {
		textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			if (Input.GetKeyUp (KeyCode.H)){
				CheckLetter ('h');
			}
			if (Input.GetKeyUp (KeyCode.E)){
				CheckLetter ('e');
			}
			if (Input.GetKeyUp (KeyCode.L)){
				CheckLetter ('l');
			}
			if (Input.GetKeyUp (KeyCode.O)){
				CheckLetter ('o');
			}
		}
	}

	void CheckLetter(char letter) {
		if (index > target.Length) {
			return;
		}
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
		if (other.gameObject.name == "cnndonlemon") {
			active = true;
		}
	}

	bool CheckCorrect() {
		return textMesh.text == target;
	}
}
