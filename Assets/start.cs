using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	public GameObject Start_Cube;

	// Use this for initialization
	void Start () {
		GetComponent<Camera_Control> ().enabled = false;
		Start_Cube.GetComponent<Rigidbody> ().useGravity = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			GetComponent<Camera_Control> ().enabled = true;
			Start_Cube.GetComponent<Rigidbody> ().useGravity = true;
		}

	}
}
