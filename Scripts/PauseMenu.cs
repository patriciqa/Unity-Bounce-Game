using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private static bool GameIsPaused = false;
    public GameObject pauseMenuUI;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadStart() {
        Debug.Log("Loading Start");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");

    }

    public void QuitGame() {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}