using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravith : MonoBehaviour {

	public GameObject affected;

	// Use this for initialization
	void Start () {
		affected.GetComponent<Rigidbody> ().useGravity = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col){

		affected.GetComponent<Rigidbody> ().useGravity =  true;

	}
}
