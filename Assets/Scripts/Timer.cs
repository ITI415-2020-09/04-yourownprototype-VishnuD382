using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    public float targetTime = 60.0f;
    public Text timer_1;

    void Start()
    {

        timer_1 = GetComponent<Text>();

    }


    void Update()
    {
        if(targetTime > 0)
        {
            targetTime -= Time.deltaTime;
            timer_1.text = "Timer: " + Math.Round(targetTime, 1);

        }

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        //do your stuff here.
        timer_1.text = "Time is Up!!";
    }

}
