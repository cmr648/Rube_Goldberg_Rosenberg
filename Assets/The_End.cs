using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The_End : MonoBehaviour {

	public GameObject End_Text;

	// Use this for initialization
	void Start () {
		End_Text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		End_Text.SetActive (true);

	}

}
