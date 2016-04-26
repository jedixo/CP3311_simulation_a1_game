using UnityEngine;


public class MovingPlatformsx : MonoBehaviour
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
            transform.Translate((float)0.03, 0, 0, Space.World);
            if (transform.position.x >= max) {
                outward = false;
            }
        } else {
            transform.Translate((float)-0.03, 0, 0, Space.World);
            if (transform.position.x <= min)
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