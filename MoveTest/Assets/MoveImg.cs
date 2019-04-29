using UnityEngine;
using System.Collections;

public class MoveImg : MonoBehaviour {

  float xSpeed = 0.2f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(this.xSpeed, 0, 0);
	}
}
