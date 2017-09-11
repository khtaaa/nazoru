using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cube : MonoBehaviour {
	Vector3 startY;

	// Use this for initialization
	void Start () {
		startY = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y - 0.01f, transform.position.z);
		if (transform.position.y <= startY.y-4) {
			transform.position = startY;
		}
	}
}
