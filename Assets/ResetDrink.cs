using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetDrink : MonoBehaviour
{

    public TextMeshProUGUI resetDrinkMsg;


    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Glass"))
        {
            resetDrinkMsg.text = "Reset Drink!"; // display win message
            //Debug.Log("Reset Contents");
            collision.gameObject.GetComponent<GlassController>().ResetContent();
            //Debug.Log("Content Cleared");

        }
    }


}
