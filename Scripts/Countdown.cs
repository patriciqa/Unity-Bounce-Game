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
    private bool StartCountdown;
    private float Wait = 3.0f;

    private void Start()
    {
        currentTime = startingTime;
        StartCoroutine(StartDelay());

    }



    void Update()
    {
        LevelCountdown();
    }

    public void LevelCountdown()
    {
        if(StartCountdown == true)
        {
            currentTime -= 1 * Time.deltaTime;
            text.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                FindObjectOfType<GameManager>().EndGame();
            }
            else if (currentTime <= 3)
            {
                text.color = Color.red;
            }
        }
    }

    IEnumerator StartDelay()
    {
        StartCountdown = false;
        yield return new WaitForSeconds(Wait);
        StartCountdown = true;
    }
}
