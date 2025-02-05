using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public int score;
    public int scoreChange;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    public void scoreUP()
    {
        score += scoreChange;
        updateScore();
    }
    public void scoreDOWN()
    {
        score -= scoreChange;
        updateScore();
    }
    public void scoreRESET()
    {
        score = 0;
        updateScore();
    }
    public void updateScore()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}
