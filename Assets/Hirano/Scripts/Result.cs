using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField]
    private int score = Data.SCORE;
    [SerializeField]
    private int maxscore, minscore;
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Text ResultLabel;

	// Use this for initialization
	void Start ()
    {
        if (score <= minscore)
        {
            FailedScore();
        }
        else
        {
            SuccessScore();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void SuccessScore()
    {
        ResultLabel.text = "CLEAR";
        anim.SetBool("clear",true);
    }

    void FailedScore()
    {
        ResultLabel.text = "FAILDE";
        anim.SetBool("failde", true);
    }
}
