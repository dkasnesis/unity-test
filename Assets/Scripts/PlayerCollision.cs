using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement move;
    public void OnCollisionEnter(Collision collision)
    {
      if (collision.collider.tag == "obstacle")
          {
            Debug.Log("mpravo");
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
      
    }
}
