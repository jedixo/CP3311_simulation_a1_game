﻿using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float delta = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, delta, 0);
	
	}
}
