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
    bool started = false;

    private void Start()
    {
        currentTime = startingTime;
        started = false;
    }

    private void delayedTime() {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            started = true;
        }
    }

    

    void Update()
    {
        delayedTime();
        if (started == true)
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
}
