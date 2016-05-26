using UnityEngine;
using System.Collections;

public class waterPhysics : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter()
    {
        player.GetComponent<Rigidbody>().mass = (player.GetComponent<Rigidbody>().mass)/2;
    }
}
