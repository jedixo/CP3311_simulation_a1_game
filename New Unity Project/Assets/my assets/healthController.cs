using UnityEngine;
using System.Collections;

public class healthController : MonoBehaviour {

	public int healthStatus;
	public int sceneNumber; //reloads level if died
	private GameObject levelVariables;
    public GameObject hitBox;
    private MeshRenderer hit;

	void Start () {
		levelVariables = GameObject.Find("levelVariables");
        hit = hitBox.GetComponent<MeshRenderer>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            
            healthStatus--;
            hit.enabled = true;
            Debug.Log(healthStatus);
            if (healthStatus == 1)
            {
                levelVariables.GetComponent<currencyRecorder>().coins = 0;
            }
            else if (healthStatus == 0)
            {
                Application.LoadLevel(sceneNumber);
            }
        }
    }
    
}
