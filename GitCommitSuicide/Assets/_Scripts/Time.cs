using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class Time : MonoBehaviour
{

    public int timeLeft = 60;
    public TextMeshProUGUI countdown;

    void Start()
    {
        StartCoroutine("LoseTime");

    }

    void Update()
    {
        countdown.text = ("Time: " + timeLeft);

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