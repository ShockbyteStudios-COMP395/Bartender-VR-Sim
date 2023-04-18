using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBottleController : MonoBehaviour
{
    public Transform b1;
    public Transform b2;
    public Transform b3;
    public Transform b4;
    public Transform b5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the "Bottle" tag
        if (collision.gameObject.CompareTag("Bottle"))
        {
            // Retrieve the original transform of the collided object
            Debug.Log(collision.gameObject.name);

            Transform originalTransform = null;
            if (collision.gameObject == b1.gameObject)
            {
                originalTransform = b1;
            }
            else if (collision.gameObject == b2.gameObject)
            {
                originalTransform = b2;
            }
            else if (collision.gameObject == b3.gameObject)
            {
                originalTransform = b3;
            }
            else if (collision.gameObject == b4.gameObject)
            {
                originalTransform = b4;
            }
            else if (collision.gameObject == b5.gameObject)
            {
                originalTransform = b5;
            }

            // Reset the transform of the collided object to the original transform
            if (originalTransform != null)
            {
                UnityEngine.Debug.Log(originalTransform.position);

                collision.gameObject.transform.position = originalTransform.position;
                collision.gameObject.transform.rotation = originalTransform.rotation;
            }
        }
    }
    }
