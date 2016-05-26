using UnityEngine;
using System.Collections;

public class healthController : MonoBehaviour {

	public int healthStatus = 2;
	public int sceneNumber; //reloads level if died
	private GameObject levelVariables;

	void Start () {
		levelVariables = GameObject.Find("levelVariables");
	}

	void OnTriggerEnter(Collider other) {
		
		healthStatus--;
		if (healthStatus == 1) {
			levelVariables.GetComponent<currencyRecorder> ().coins = 0;
		} else if (healthStatus == 0) {
			Application.LoadLevel (sceneNumber);
		}
	}
}
