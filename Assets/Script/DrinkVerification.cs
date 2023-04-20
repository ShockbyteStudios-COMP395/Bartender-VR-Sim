using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DrinkVerification : MonoBehaviour
{
    [SerializeField] private int id;
    private float[][] drinks = new float[4][];
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public Canvas winTextC;
    public Canvas GameUI;
    public TextMeshProUGUI incorrectDrink;
    private ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();

        winTextC.gameObject.SetActive(false); // set the winText object to inactive
        GameUI.gameObject.SetActive(true); // set the winText object to inactive

        drinks[0] = new float[] { 1.02f, 1.02f, 0, 0,0 };
        drinks[1] = new float[] { 1.02f, 0, 0, 0 ,1.02f};
        drinks[2] = new float[] { 1.02f, 1.02f, 1.02f, 0,0 };
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Glass"))
        {
            if (VerificateDrink(collision.gameObject.GetComponent<GlassController>().contents))
            {
                Debug.Log("Drink is correct");
                scoreManager.UpdateScore(1);
                scoreText.text = "Drinks Served: " + scoreManager.score + "/3";
                incorrectDrink.text = "Drink Served";

                if (scoreManager.score >= 3)
                {
                    Time.timeScale = 0; // stop the game
                    winText.text = "You Win!"; // display win message
                    winTextC.gameObject.SetActive(true); // set the winText object to inactive
                    GameUI.gameObject.SetActive(false); // set the winText object to inactive
                    SceneManager.LoadScene(0);


                }
            }
        }
    }

    bool VerificateDrink(float[] contents)
    {
        for (int i = 0; i < contents.Length; i++)
        {
            if (!Mathf.Approximately(contents[i], drinks[id][i]))
            {
                incorrectDrink.text = "Wrong Drink";

                Debug.Log("Drink is incorrect contents: " + contents[i] + " correct value: " + drinks[id][i]);
                return false;
            }
        }

        return true;


    }
}
