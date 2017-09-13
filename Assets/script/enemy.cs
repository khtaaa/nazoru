using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//オブジェクトが衝突したとき
	void OnTriggerEnter(Collider col) {
		if (col.CompareTag ("Player")) {
			Application.LoadLevel ("gameover");
		}
	}
}
