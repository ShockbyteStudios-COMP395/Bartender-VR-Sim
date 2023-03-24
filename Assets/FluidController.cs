using Obi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FluidController : MonoBehaviour
{

    public GameObject bottle;
    public ObiEmitter component;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Euler: " + flash.gameObject.transform.eulerAngles.x);
        if (bottle.gameObject.transform.eulerAngles.x <= 90)
        {
            component.speed = 1f;
        }
        else
        {
            component.speed = 0f;
        }
    }
}

