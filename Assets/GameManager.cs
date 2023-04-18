using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GlassController glassController;
    private float[] manhattan = new float[4] {0, 1.02f, 0, 1.02f };
    private float[] negroni = new float[4] { 1.02f, 1.02f, 1.02f, 0 };
    private float[] martini = new float[4] { 1.02f, 1.02f, 0, 0 };
    private float[][] drinks = new float[3][];


    int[][] arrayOfArrays = new int[3][];

    private void Start()
    {
        drinks[0] = new float[] { 0, 1.02f, 0, 1.02f };
        drinks[1] = new float[] { 1.02f, 1.02f, 1.02f, 0 };
        drinks[2] = new float[] { 1.02f, 1.02f, 0, 0 };
    }
    // Update is called once per frame
    void Update()
    {
        if (glassController.shaked == true && glassController.stirred == false)
        {
            for (int i = 0; i < glassController.contents.Length; i++)
            {
                if (!(manhattan[i].Equals(glassController.contents[i]))){
                    Debug.Log("Drink was incorrect");
                    break;
                }
            }

            Debug.Log("Congratilations, you made a Dry Manhattan");
        }
        else if(glassController.stirred == true && glassController.shaked == false)
        {
            for (int i = 0; i < glassController.contents.Length; i++)
            {
                if (!(negroni[i].Equals(glassController.contents[i])))
                {
                    Debug.Log("Drink was incorrect");
                    break;
                }
                Debug.Log("Congratilations, you made a Negroni");
            }
        }
    }
}
