using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StartCountdown : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public TextMeshProUGUI startText;
    public GameObject StartCountdownUI;
   
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            StartCountdownUI.SetActive(false);
        }
    }
}
