using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public int sceneNumber;


	void OnTriggerEnter(Collider other) {
		
		Application.LoadLevel(sceneNumber);
	}
}