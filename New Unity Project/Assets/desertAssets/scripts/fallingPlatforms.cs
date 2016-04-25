using UnityEngine;
using System.Collections;

public class fallingPlatforms : MonoBehaviour {

	public int framesToWait = 60;
	public int framesToWait2 = 60;
	private int count = 0;
	private int count2 = 0;
	private bool countOn = false;
	private Vector3 position;

	// Use this for initialization
	void Start () {
		position = this.gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (countOn) {
			if (count == framesToWait) {
				Vector3 move = new Vector3 (0, -10, 0);
				this.gameObject.transform.position = move;
					if (count2 == framesToWait2) {
						this.gameObject.transform.position = position;
						count = 0;
						count2 = 0;
						countOn = false;
					} else {
						count2++;
					}

			} else {
				count++;
			}
		}
	
	}

	void OnTriggerEnter(Collider other) {
		countOn = true;
	}
		


}
