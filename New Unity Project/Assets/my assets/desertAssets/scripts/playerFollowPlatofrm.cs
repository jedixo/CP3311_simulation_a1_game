﻿using UnityEngine;
using System.Collections;

public class playerFollowPlatofrm : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other){

		if(other.gameObject.tag == "platform"){
			transform.parent = other.transform;

		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "platform"){
			transform.parent = null;

		}
	}    
}
