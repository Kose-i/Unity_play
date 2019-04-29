using UnityEngine;
using System.Collections;

public class GitprofileController : MonoBehaviour {

  float rotSpeed = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    this.rotSpeed = 10;
    transform.Rotate(0, 0, this.rotSpeed);
	}
}
