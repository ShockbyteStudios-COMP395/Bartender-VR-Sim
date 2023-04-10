using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{

    float[] contents = new float[8];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
