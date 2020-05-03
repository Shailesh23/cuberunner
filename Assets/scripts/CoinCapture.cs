using UnityEngine;

public class CoinCapture : MonoBehaviour
{
    public float rotateAmount = 150f; 
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().CoinCaptured();

        //remove coin from view after it has been captured
        this.gameObject.SetActive(false);
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 
            , rotateAmount * Time.deltaTime, 0);
    }
}
