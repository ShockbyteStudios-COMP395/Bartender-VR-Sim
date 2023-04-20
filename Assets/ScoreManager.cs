using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // Remove the "static" keyword

    private void Start()
    {
        score = 0;
        scoreText.text = "Drinks Served: " + score + "/3";
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Drinks Served: " + score + "/3";
    }
}
