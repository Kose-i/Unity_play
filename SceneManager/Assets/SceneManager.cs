using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using SceneManagement;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetMouseButton(0)) {
      SceneManager.LoadScene("FinalScene");
    }
	}
}
