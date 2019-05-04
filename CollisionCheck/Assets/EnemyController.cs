using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

  public static float x_diff = 0.05f;
  public static float zero_f = 0.0f;

  GameObject player;

	// Use this for initialization
	void Start () {
    this.player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(-x_diff, zero_f, zero_f);
    if (transform.position.x < -10.0f) {
      Destroy(gameObject);
    }

    Vector2 p1 = transform.position; // Enemy pos
    Vector2 p2 = this.player.transform.position; // Player pos
    Vector2 diff = p1 - p2;
    float d = diff.magnitude;
    if (d < 2f) { // collision play
      Destroy(gameObject);
    }
	}
}
