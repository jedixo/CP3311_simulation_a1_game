using UnityEngine;
using System.Collections;

public class movePlatform : MonoBehaviour
{

    public bool x = false;
    public bool y = false;
    public bool z = false;
    public bool limit = true;
    public double maxValue = 1;
    public double minValue = 0;
    public float delta = (float)0.03;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(getDelta(x), getDelta(y), getDelta(z));
        checkLimit(limit);
    }

    float getDelta(bool axis)
    {
        if (axis)
        {
            return delta;
        }
        return 0f;
    }

    void checkLimit(bool lim)
    {
        if (lim)
        {

            if (x)
            {
                if (transform.position.x >= maxValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
            else if (y)
            {
                if (transform.position.y >= maxValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
            else {
                if (transform.position.z >= maxValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
        }
        else {

            if (x)
            {
                if (transform.position.x <= minValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
            else if (y)
            {
                if (transform.position.y <= minValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
            else {
                if (transform.position.z <= minValue)
                {
                    delta = delta * -1;
                    limit = !lim;
                }
            }
        }
    }
}