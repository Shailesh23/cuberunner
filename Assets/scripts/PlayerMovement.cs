using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float forwardForce = 500f;
    public float sidewaysForce = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {

        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x < Screen.width / 2)
            {
                Debug.Log("move left");
                rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                Debug.Log("move right");
                rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
