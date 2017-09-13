using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cube : MonoBehaviour {
	Vector3 start;
	public bool ok;

	// Use this for initialization
	void Start () {
		start = transform.position;
		ok = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (ok == true)
			transform.position = new Vector3 (start.x, transform.position.y - 0.01f, start.z);
		if (transform.position.y <= start.y-4) {
			transform.position = start;
		}

		ok = true;
	}
	//オブジェクトが衝突したとき
	void OnTriggerEnter(Collider col) {
		if (col.CompareTag ("line")) {
			ok = false;
		}
	}

	//オブジェクトが離れた時
	void OnTriggerStay(Collider col) {
		if (col.CompareTag ("line")) {
			ok = false;
		}
	}
}
