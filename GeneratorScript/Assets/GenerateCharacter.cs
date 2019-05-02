using UnityEngine;
using System.Collections;

public class GenerateCharacter : MonoBehaviour {

  public GameObject characterPrefab;

  float span = 1.0f;
  float delta = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    this.delta += Time.deltaTime;
    if (this.delta > this.span) {
      this.delta = 0;
      GameObject go = Instantiate(characterPrefab) as GameObject;
      int py = Random.Range(-3, 3);
      go.transform.position = new Vector3(7, py, 0);
    }
	}

}
