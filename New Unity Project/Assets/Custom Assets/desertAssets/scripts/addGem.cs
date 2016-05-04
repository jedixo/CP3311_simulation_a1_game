using UnityEngine;
using System.Collections;

public class addGem : MonoBehaviour {

	public GameObject levelVariables;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		levelVariables.GetComponent<currencyRecorder> ().gems++;
		Destroy (this.gameObject);

	}
}
