using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class WordReplaceScript : MonoBehaviour {

	public string target = "hello";
	int index = 0;
	bool active = false;
	TextMesh textMesh;

	void Start () {
		textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			foreach (KeyCode code in System.Enum.GetValues(typeof(KeyCode))) {
				if (Input.GetKeyUp (code)) {
					var str = code.ToString ();
					if (str.Length == 1) {
						CheckLetter (System.Char.ToLower(str [0]));
					}
				}
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
