using UnityEngine;
using System.Collections;

public class movePlatform : MonoBehaviour
{
    public GameObject platform;
    public float half;
    public float speed;
    public bool y;
    public bool x;
    public bool z;
    private Vector3 movementmax;
    private Vector3 movement;
    private bool turn;
    float py;
    float px;
    float pz;
    float my;
    float mz;
    float mx;

    // Use this for initialization
    void Start()
    {
        movement = new Vector3(0f, 0f, 0f);
        movementmax = new Vector3(0f, 0f, 0f);
        if (y)
        {
            movementmax = new Vector3(movementmax.x + 0f,  movementmax.y + half, movementmax.z + 0f);
            movement = new Vector3(movement.x + 0f, movement.y + speed, movement.z + 0f);
        }
        if (x)
        {
            movementmax = new Vector3(movementmax.x + half, movementmax.y + 0f, movementmax.z + 0f);
            movement = new Vector3(movement.x + speed, movement.y + 0f, movement.z + 0f);
        }
        if (z)
        {
            movementmax = new Vector3(movementmax.x + 0f, movementmax.y + 0f, movementmax.z + half);
            movement = new Vector3(movement.x + 0f, movement.y + 0f, movement.z + speed);
        }
        my = movement.y;
        mx = movement.x;
        mz = movement.z;
    }

        // Update is called once per frame
        void Update()
    {
        
        py = platform.transform.localPosition.y;
        px = platform.transform.localPosition.x;
        pz = platform.transform.localPosition.z;
        
        if (platform.transform.localPosition.x > movementmax.x || platform.transform.localPosition.z > movementmax.z || platform.transform.localPosition.y > movementmax.y)
        {
            turn = false;
        }else if (platform.transform.localPosition.x < (movementmax.x)*-1 || platform.transform.localPosition.z < (movementmax.z)*-1 || platform.transform.localPosition.y < (movementmax.y)*-1)
        {

            turn = true;
        }
        if (turn)
            platform.transform.localPosition = new Vector3(px + mx, py + my, pz + mz);
        else
            platform.transform.localPosition = new Vector3(px - mx, py - my, pz - mz);
    }
}