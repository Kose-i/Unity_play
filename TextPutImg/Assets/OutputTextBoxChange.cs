using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class OutputTextBoxChange : MonoBehaviour {

  GameObject textBox;

	// Use this for initialization
	void Start () {
    this.textBox = GameObject.Find("OutputTextBox");
    this.textBox.GetComponent<Text>().text = "Push SpaceKey";
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.Space)) {
      this.textBox.GetComponent<Text>().text = "settup";
    }
	}
}
