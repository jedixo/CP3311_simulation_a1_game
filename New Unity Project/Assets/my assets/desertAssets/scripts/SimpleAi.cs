using UnityEngine;
using System.Collections;

public class SimpleAi : MonoBehaviour {
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    Rigidbody rigidbody;
    Renderer renderer;

 

    // Use this for initialization
    void Start () {
        renderer = gameObject.GetComponent<Renderer>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position,transform.position);
        if (fpsTargetDistance > enemyLookDistance) {
            renderer.material.color = Color.green;
        }
        if (fpsTargetDistance < enemyLookDistance)
        {
            renderer.material.color = Color.yellow;
            print("look");
            lookAtPlayer();
        }
        if (fpsTargetDistance < attackDistance)
        {
            renderer.material.color = Color.red;
            print("ATAK");
            attackPlease();

        }



    }


    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        
    }


    void attackPlease()
    {
        rigidbody.AddForce(transform.forward * enemyMovementSpeed);
    }

}
