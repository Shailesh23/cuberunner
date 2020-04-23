using UnityEngine;

public class MoveObstracle : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float sideMovementSpeed = 50f;
    public bool isMoveRight = true;
    public int moveDistance = 15;

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight){
            rigidBody.AddForce(sideMovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else {
            rigidBody.AddForce(-sideMovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigidBody.position.x >= moveDistance){
            isMoveRight = false;
            Debug.Log("moving right");
        } else if(rigidBody.position.x <= -moveDistance){
            Debug.Log("moving left");
            isMoveRight = true;
        }
    }
}
