using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class waterPhysics : MonoBehaviour {
    public GameObject player;
	public GameObject playerFpc;
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
		playerFpc.GetComponent<FirstPersonController>().m_GravityMultiplier = 0.5f;
        player.GetComponent<Rigidbody>().mass = 50;
        player.GetComponent<Rigidbody>().drag = 50;
        water.enabled = true;
        Debug.Log(water);
    }
    void OnTriggerExit()
    {
		playerFpc.GetComponent<FirstPersonController> ().m_GravityMultiplier = 1f;
		player.GetComponent<Rigidbody>().mass = 1;
		player.GetComponent<Rigidbody>().drag = 1;
        water.enabled = false;
    }
}
