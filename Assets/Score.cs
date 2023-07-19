using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int myScore = 0;

    void Update()
    {
        scoreText.text = "score " + myScore.ToString();
    }

    public void AddScore(int score)
    {
        myScore += score; // Increment the score by the given value
    }
}
