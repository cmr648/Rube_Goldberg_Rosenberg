using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tip_collider : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Tip_Ball") {

			gameObject.transform.Rotate (14, 0, 0);

		}

	}
}
