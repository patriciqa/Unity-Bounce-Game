using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 5f;

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //Restart();

        }
    }

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
