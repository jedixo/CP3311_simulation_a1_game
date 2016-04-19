using UnityEngine;
using System.Collections;

public class MainPlayerController : MonoBehaviour {
    public float rotateSpeed;
    public float fowardSpeed;
    public float jumpHieght;
    //private CharacterController playerController;
   // public Animator anim;


    // Use this for initialization
    void Start () {
        playerController = GetComponent < CharacterController>();
        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (playerController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                playerController.Move(new Vector3(0,jumpHieght,0));
            }
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float speed = fowardSpeed * Input.GetAxis("Vertical");
        playerController.SimpleMove(speed * forward);
	}

}
