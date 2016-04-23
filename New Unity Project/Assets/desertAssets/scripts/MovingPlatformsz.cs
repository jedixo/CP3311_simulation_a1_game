using UnityEngine;


public class MovingPlatformsz : MonoBehaviour
{

    private bool outward = true;
    public double max;
    public double min;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (outward) {
            transform.Translate(0, 0, (float)0.03, Space.World);
            if (transform.position.z >= max) {
                outward = false;
            }
        } else {
            transform.Translate(0, 0, (float)-0.03, Space.World);
            if (transform.position.z <= min)
            {
                outward = true;
            }
        }

//        if (transform.position.x <= max)
//        {
//            transform.Translate((float)0.03, 0, 0, Space.World);

//        }
//        else if (transform.position.x >= min)
//        {
//            transform.Translate((float)-0.03, 0, 0, Space.World);
//        }
    }
}