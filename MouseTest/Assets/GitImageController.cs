using UnityEngine;
using System.Collections;

public class GitImageController : MonoBehaviour {

  float rotateSpeed = 0;
  const int threahold_x_pos = 400;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetMouseButtonDown(0)) {
      this.rotateSpeed = 10;
      if (Input.mousePosition.x < threahold_x_pos) {
        this.rotateSpeed = -this.rotateSpeed;
      }
      Debug.Log(this.rotateSpeed);
      transform.Rotate(0, 0, this.rotateSpeed); // 
    }

	}
}
