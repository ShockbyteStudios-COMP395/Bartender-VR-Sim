using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetDrink : MonoBehaviour
{



    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Glass"))
        {
            Debug.Log("Reset Contents");
            collision.gameObject.GetComponent<GlassController>().ResetContent();
            Debug.Log("Content Cleared");

        }
    }


}
