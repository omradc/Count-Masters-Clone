using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeNumber : MonoBehaviour
{
    public TextMeshProUGUI gateText;
    public GameObject playerPrefab;
    private GameObject players;
    Vector3 spawnPos;
    public int gateNumberAdd;
    public int gateNumberMultiply;
    public int gateIndex;
    public int total;
    public static int playerNumber = 1;
    private void Start()
    {
        players = GameObject.Find("Players");
        gateNumberAdd = Random.Range(10,50);
        gateNumberMultiply = Random.Range(1, 6);

        gateIndex = Random.Range(0, 2);
        if (gateIndex == 0)
        {
            gateText.text = "x" + gateNumberMultiply;
        }
        else
        {
            gateText.text = "+" + gateNumberAdd;
        }

    }
    private void Update()
    {

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (gateIndex == 0) // çarp
            {
                // kapı sayısı ve oyuncu sayısının çarpımı kadar eklemek yerine, direkt çarpım sonucu kadar oyuncu sayısı yarattım.
                total = (gateNumberMultiply * playerNumber) - playerNumber;

            }

            if (gateIndex == 1) // topla
            {
                total = gateNumberAdd;

            }


            if (total < 500)
            {
                for (int i = 0; i < total; i++)
                {
                    spawnPos = new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));
                    Instantiate(playerPrefab, players.transform.position + spawnPos, transform.rotation).transform.SetParent(players.transform);
                    playerNumber++;

                }
                // player kapıdan çıktıktan sonra enemyNumber değişkeninde playerNumber değişkenini tuttum, çünkü kapıdan sonra gelen engeller 
                //playerNumber'ı azaltsa bile enemyNumber sabit kalacak. 
                SpawnEnemy.Instance.enemyNumber = playerNumber;
                Debug.Log("Player Number: " + playerNumber);
            }
        }

    }


}
