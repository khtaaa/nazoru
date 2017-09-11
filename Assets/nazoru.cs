using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nazoru : MonoBehaviour {
	GameObject linePrefab;
	public GameObject Prefab;
	public GameObject Prefab2;
	public float lineLength = 0.2f;
	public float lineWidth = 0.1f;

	private Vector3 touchPos;

	// Use this for initialization
	void Start () {
		linePrefab = Prefab;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			if (linePrefab == Prefab) {
				linePrefab = Prefab2;
			} else {
				linePrefab = Prefab;
			}
		}
		if(Input.GetMouseButtonDown(0))
		{
			touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			touchPos.z=0;
		}

		if(Input.GetMouseButton(0))
		{

			Vector3 startPos = touchPos;
			Vector3 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			endPos.z=0;

			if((endPos-startPos).magnitude > lineLength){
				GameObject obj = Instantiate(linePrefab, transform.position, transform.rotation) as GameObject;
				obj.transform.position = (startPos+endPos)/2;
				obj.transform.right = (endPos-startPos).normalized;

				obj.transform.localScale = new Vector3( (endPos-startPos).magnitude, lineWidth , lineWidth );

				obj.transform.parent = this.transform;

				touchPos = endPos;
			}
		}
	}
}
