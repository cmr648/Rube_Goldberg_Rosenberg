using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this script on your trigger

public class Camera_Trigger : MonoBehaviour {

	public Transform lookOverride;
	public Transform moveOverride;
	public float NewMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col){
		Debug.Log ("CameraTrigger");

		Camera_Control camControl = Camera.main.GetComponent<Camera_Control> ();

		camControl.moveToTarget = moveOverride;
		camControl.lookAtTarget = lookOverride;
		camControl.Move_Speed = NewMove;

	}

	void OnDrawGizmos(){
		Gizmos.DrawLine (transform.position, moveOverride.position);
		Gizmos.color = Color.cyan;
	
	}


}
