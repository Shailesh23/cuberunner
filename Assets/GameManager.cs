using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartTime = 1f;
    public GameObject completeLevelUI;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");

            Invoke("RestartGame", restartTime);
        }
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void CloseGame()
    {
        Application.Quit();
    }

    public void CompleteLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2) {
            completeLevelUI.SetActive(true);
            Debug.Log("last level compelted");
            Invoke("CloseGame", restartTime);
        } else {
            completeLevelUI.SetActive(true);
            Debug.Log("last level compelted");
            Invoke("LoadNextScene", restartTime);
        }
        
    }
}
