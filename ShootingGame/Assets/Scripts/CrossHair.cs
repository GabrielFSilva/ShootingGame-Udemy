using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Mouse X") / 5f;
		float v = Input.GetAxis ("Mouse Y") / 5f;

		transform.Translate (new Vector3 (h, v));

		float x = transform.position.x;
		float y = transform.position.y;

		x = Mathf.Clamp (x, -10f, 10f);
		y = Mathf.Clamp (y, -6f, 6f);
		transform.position = new Vector3 (x, y);
	}
}
