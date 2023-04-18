using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkVerification : MonoBehaviour
{
    [SerializeField] private int id;
    private float[][] drinks = new float[3][];

    private void Start()
    {
        drinks[0] = new float[] { 0, 1.02f, 0, 1.02f };
        drinks[1] = new float[] { 1.02f, 1.02f, 1.02f, 0 };
        drinks[2] = new float[] { 1.02f, 1.02f, 0, 0 };
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Glass"))
        {
            VerificateDrink(collision.gameObject.GetComponent<GlassController>().contents);
        }
    }

    void VerificateDrink(float[] contents)
    {
        for (int i = 0; i < contents.Length; i++)
        {
            if (!(contents[i].Equals(drinks[id][i])))
            {
                Debug.Log("Drink is incorrect");
            }
        }

        Debug.Log("Drink is correct");
    }
}
