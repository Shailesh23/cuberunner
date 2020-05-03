using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other) {
        Debug.Log("game level compelte");
        gameManager.CompleteLevel();   
    }
}
   