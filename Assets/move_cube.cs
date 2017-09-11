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
	void Update () {
		if (ok == true)
			transform.position = new Vector3 (start.x, transform.position.y - 0.01f, start.z);
		if (transform.position.y <= start.y-4) {
			transform.position = start;
		}
	}
	/*
	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("line")) {
			ok = false;
		}
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision col) {
		if (col.gameObject.CompareTag ("line")) {
			ok = true;
		}
	}*/
}
