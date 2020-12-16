using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            playerMovement.enabled = false;

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
