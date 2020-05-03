using UnityEngine;
using UnityEngine.UI;

public class QuitButtonScript : MonoBehaviour
{   
   public void HandleQuitButton(string text)
    {
        FindObjectOfType<GameManager>().CloseGame();
    }
}
