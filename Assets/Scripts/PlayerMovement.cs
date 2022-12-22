using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2000f;
    public float steerSpeed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime,ForceMode.VelocityChange);
        if (Input.GetKey("a"))
        {
            rb.AddForce(-steerSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(steerSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 1750* Time.deltaTime, 0);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
            
    }
}

   