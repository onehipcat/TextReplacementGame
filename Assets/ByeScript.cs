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
			if (target[index] == 'h') {
				StringBuilder sb = new StringBuilder(textMesh.text, target.Length);
				sb.Length = target.Length;
				sb[index] = 'h';
				textMesh.text = sb.ToString();
				index++;
				Debug.Log ("h correctly pressed");
			}
		}
		if (Input.GetKey (KeyCode.E)){
			if (target[index] == 'e') {
				StringBuilder sb = new StringBuilder(textMesh.text, target.Length);
				sb.Length = target.Length;
				sb[index] = 'e';
				textMesh.text = sb.ToString();
				index++;
				Debug.Log ("e correctly pressed");
			}
		}
		if (Input.GetKey (KeyCode.L)){
			if (target[index] == 'l') {
				StringBuilder sb = new StringBuilder(textMesh.text, target.Length);
				sb.Length = target.Length;
				sb[index] = 'l';
				textMesh.text = sb.ToString();
				index++;
				Debug.Log ("l correctly pressed");
			}
		}
		if (Input.GetKey (KeyCode.O)){
			if (target[index] == 'o') {
				StringBuilder sb = new StringBuilder(textMesh.text, target.Length);
				sb.Length = target.Length;
				sb[index] = 'o';
				textMesh.text = sb.ToString();
				Debug.Log ("o correctly pressed");
			}
		}
	}
}
