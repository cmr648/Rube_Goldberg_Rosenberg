using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// on the trigger
	void OnTriggerEnter (Collider col){
		Debug.Log ("Trigger");

	}
}
