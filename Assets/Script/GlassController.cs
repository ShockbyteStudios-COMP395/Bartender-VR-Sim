using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{

    
    public float[] contents = new float[4];
    public bool shaked = false;
    public bool stirred = false;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Shaker"))
        {
            shaked = true;
        }

        if (collision.gameObject.tag.Equals("Stirrer"))
        {
            stirred = true;
        }
    }

    public void fillWithAlcohol(int id)
    {
        
        if(contents[id] <= 1)
        {
            contents[id] += 0.02f;
            Debug.Log(contents[id]);
        }
    }
}
