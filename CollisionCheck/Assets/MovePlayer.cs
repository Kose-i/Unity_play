using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

  public float x_pos;
  public float y_pos;

  public static float thread_left = 0f;
  public static float thread_right = 20f;
  public static float thread_top = 4f;
  public static float thread_buttom = -4f;

  float x_move_diff = 0.5f;
  float y_move_diff = 0.5f;
  float zero_f = 0.0f;

	// Use this for initialization
	void Start () {
    this.x_pos = 0f;
    this.y_pos = 0f;
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.LeftArrow)) {
      if (thread_left < this.x_pos) {
        transform.Translate(-x_move_diff,zero_f,zero_f);
        x_pos -= x_move_diff;
      }
    } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
      if (this.x_pos < thread_right) {
        transform.Translate(x_move_diff, zero_f, zero_f);
        x_pos += x_move_diff;
      }
    } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
      if (thread_buttom < this.y_pos) {
        transform.Translate(zero_f, -y_move_diff, zero_f);
        y_pos -= y_move_diff;
      }
    } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
      if (this.y_pos < thread_top) {
        transform.Translate(zero_f, y_move_diff, zero_f);
        y_pos += y_move_diff;
      }
    }
	}
}
