using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] float playerSpeed=0.2f;
    void Start()
    {
        playerController = GameObject.Find("Players").GetComponent<PlayerController>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (playerController.X < 0)
            {
                playerController.speedX = 0;     
            }
            if (playerController.X > 0)
            {
                playerController.speedX = playerSpeed;
            }
        }
    }
}
