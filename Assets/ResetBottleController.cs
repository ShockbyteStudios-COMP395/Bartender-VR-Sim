using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBottleController : MonoBehaviour
{
    public Vector3 initialPosition;
    public Quaternion initialRotation = Quaternion.identity;
    private Vector3 currentPosition;
    private Quaternion currentRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Save the initial position and rotation as the original transform
        initialPosition = gameObject.transform.localPosition;

        Debug.Log(initialPosition);

        currentRotation = initialRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetBottle()
    {
        //Debug.Log("Resetting bottle");
        // Reset the position and rotation of the bottle to the initial values
        this.gameObject.transform.localPosition = initialPosition;
        this.gameObject.transform.rotation = currentRotation;
    }
}
