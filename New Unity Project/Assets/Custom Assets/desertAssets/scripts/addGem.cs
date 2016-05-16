using UnityEngine;
using System.Collections;

public class addGem : MonoBehaviour {

	public GameObject levelVariables;
	public GameObject portalPane;

	// Use this for initialization
	void Start () {
		levelVariables = GameObject.Find("levelVariables");
		portalPane = GameObject.FindGameObjectWithTag("portalPane");
		portalPane.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		levelVariables.GetComponent<currencyRecorder> ().gems++;
		portalPane.SetActive (true);
		Destroy (this.gameObject);


	}
}
