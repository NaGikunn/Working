using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    int score = 0;

    int claimPoint = 0;

    [SerializeField]
    Text scoreText;

    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void ScoreDecrement()
    {
        score -= 10;
        if (score < 0)
        {
            score = 0;
        }
        claimPoint++;

        scoreText.text = "Score : " + score.ToString();
    }

    public void ScoreIncrement()
    {
        score += 200;

        scoreText.text = "Score : " + score.ToString();
    }
}
