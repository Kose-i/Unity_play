﻿using UnityEngine;
using System.Collections;

public class EachCharacterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(-0.1f, 0, 0);

    if (transform.position.x < -10.0f) { // Out screen
      Destroy(gameObject);
    }
	}
}
