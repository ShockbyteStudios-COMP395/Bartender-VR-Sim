using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GlassController : MonoBehaviour
{
    public AudioSource ShakedSound;
    public AudioSource StirredSound;
    public AudioSource ServedSound;

    public TextMeshProUGUI activityText;
    public float[] contents = new float[4];
    public bool shaked = false;
    public bool stirred = false;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Shaker"))
        {
            shaked = true;
            activityText.text = "Drink Shaked";
            ShakedSound.Play();


        }

        if (collision.gameObject.tag.Equals("Stirrer"))
        {
            stirred = true;
            activityText.text = "Drink Stirred";
            StirredSound.Play();


        }

        if (collision.gameObject.tag.Equals("Coaster"))
        {
            ServedSound.Play();


        }
    }

    public void fillWithAlcohol(int id)
    {
        
        if(contents[id] <= 1)
        {
            contents[id] += 0.02f;
        }
    }

    public void ResetContent()
    {
        contents = new float[5];
    }
}
