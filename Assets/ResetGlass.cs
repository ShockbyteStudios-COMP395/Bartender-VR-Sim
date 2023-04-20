using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ResetGlass : MonoBehaviour
{

    public Vector3 initialPosition;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = Vector3.zero; // set initial position to (0,0,0)
        gameObject.transform.localPosition = initialPosition; // set the object's position to (0,0,0)
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Coaster"))
        {
            gameObject.transform.localPosition = initialPosition; // reset object's position to (0,0,0)
        }
    }

}
