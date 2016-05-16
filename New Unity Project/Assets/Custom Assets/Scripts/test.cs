using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{

	void OnControllerColliderHit (ControllerColliderHit other)
	{
       

		if (other.gameObject.tag == "platform") {

				Vector3 prevPos = transform.position;
		
				transform.parent = other.transform;
				transform.position = prevPos;


		} else {
			transform.parent = null;

		}



		if (other.gameObject.tag == "terrain") {
			Vector3 temp = new Vector3 (0, 0, 0);
			transform.position = temp;
		}
	}
}
