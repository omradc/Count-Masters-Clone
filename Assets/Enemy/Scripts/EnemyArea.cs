using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] float playerXSpeed = 1;
    [SerializeField] float playerZSpeed = 15;

    void Start()
    {
        playerController = GameObject.Find("Players").GetComponent<PlayerController>();

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Enemy.isFollowing = true;
            playerController.speedZ = 1;
            playerController.speedX = 0;

        }
    }

    private void OnTriggerStay(Collider other)
    {
        // düşman alanında player varsa, düşman sayısı da 0 ise oyuncu hızını eski haline getir.
        if (other.gameObject.CompareTag("Player")&& transform.childCount==0)
        {
            // oyuncu hızını eski haline getir.
            playerController.speedZ = playerZSpeed;
            playerController.speedX = playerXSpeed;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("düşman sayısı = "+ transform.childCount);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Enemy.isFollowing = false;
            Destroy(gameObject);

        }
    }
}
