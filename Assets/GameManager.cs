using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartTime = 1f;
    public GameObject completeLevelUI;
    public Text coinCaptured;
    private int coinCounter = 0;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");

            Invoke("RestartGame", restartTime);
        }
        
    }

    public void CoinCaptured()
    {
        //update coin counter score
        coinCounter++;
        coinCaptured.text = coinCounter.ToString();
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void LoadNextScene()
    {
        completeLevelUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void CompleteLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0) {
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
