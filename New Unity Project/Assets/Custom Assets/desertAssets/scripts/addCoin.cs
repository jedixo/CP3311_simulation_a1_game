using UnityEngine;
using System.Collections;

public class addCoin : MonoBehaviour {

	public GameObject levelVariables;

	// Use this for initialization
	void Start () {
		levelVariables = GameObject.Find("levelVariables");

		levelVariables.GetComponent<currencyRecorder> ().totalCoins++;
	
	}
	
	// Update is called once per frame


	void OnTriggerEnter(Collider other) {
		levelVariables.GetComponent<currencyRecorder>().coins++;
		Destroy (this.gameObject);
	}
}
