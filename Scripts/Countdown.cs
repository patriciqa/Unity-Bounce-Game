using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;       
    public TextMeshProUGUI text;


    private void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        text.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (currentTime <= 3) {
            text.color = Color.red;
        }

       
    }
}
