using UnityEngine;
using System.Collections;

public class KeyUITest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.Space)) {
      Debug.Log("Space-Key Down");
    } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
      Debug.Log("RightArrow-Key Down");
    } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
      Debug.Log("LeftArrow-Key Down");
    }
	}
}
