using UnityEngine;
using System.Collections;

public class respawnPlayer : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.y <= -5) {
			Vector3 temp = new Vector3(0,0,0);
			player.transform.position = temp;
		}
	
	}
}
