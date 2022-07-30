using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    [SerializeField] private float nextLevelTime = 3;
    [SerializeField] private int nextLevelIndex;
    float t;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // player bitişe girdiğinde durur.
            other.gameObject.GetComponent<PlayerController>().speedZ = 0;
            other.gameObject.GetComponent<PlayerController>().speedX = 0;
            StartCoroutine(nextLevel());
            ChangeNumber.playerNumber = 1;
        }
    }

    IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(nextLevelTime);
        SceneManager.LoadScene(nextLevelIndex);
    }
}
