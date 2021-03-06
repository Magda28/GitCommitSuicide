﻿using System.Collections;
using UnityEngine;
using TMPro;

public class TimeHealth : MonoBehaviour
{
    public int timeLeft = 60;
    public TextMeshProUGUI countdown;
    public int playerLife = 3;
    public TextMeshProUGUI lifeCount;

    void Start()
    {
        StartCoroutine("LoseTime");
    }

    void Update()
    {
        lifeCount.text = ("Lives: " + playerLife);
        countdown.text = ("Time: " + timeLeft);
        checkLife();
    }

    void checkLife()
    {
        if(timeLeft == 0)
        {
            StopCoroutine("LoseTime");
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}