using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public GameObject player;


    void OnControllerColliderHit(ControllerColliderHit other)
    {
       
            if (other.gameObject.tag == "platform")
            {
                transform.parent = other.transform;
            }
            else {
                transform.parent = null;
            }
            if (other.gameObject.tag == "terrain")
        {
            Vector3 temp = new Vector3(0, 0, 0);
            player.transform.position = temp;
        }
    }
}
