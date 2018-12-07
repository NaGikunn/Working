using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [SerializeField]
    Text timerText;

    float timer = 0;

    // Use this for initialization
    void Start()
    {
        timer = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        timerText.text = "Time:" + timer.ToString("F0");
    }
}
