using UnityEngine;
using System.Collections;

public class waterPhysics : MonoBehaviour {
    public GameObject player;
    public GameObject waterBox;
    private MeshRenderer water;
	// Use this for initialization
	void Start () {
        water = waterBox.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter()
    {
        player.GetComponent<Rigidbody>().mass = 5;
        player.GetComponent<Rigidbody>().drag = 5;
        water.enabled = true;
        Debug.Log(water);
    }
    void OnTriggerExit()
    {
        water.enabled = false;
    }
}
