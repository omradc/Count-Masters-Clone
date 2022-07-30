using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    #region Singelton
    public static SpawnEnemy Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    #endregion
    [SerializeField] private GameObject EnemyPrefab;
    [HideInInspector] public GameObject activeEnemyAreaPos;
    [HideInInspector] public int enemyNumber;
    [HideInInspector] public int totalEnemy;
    public void EnemySPawner()
    {
        if (enemyNumber % 2 != 0)
        {
            totalEnemy = (enemyNumber + 1) / 2;
        }
        else
        {
            totalEnemy = enemyNumber / 2;
        }

        for (int i = 0; i < totalEnemy; i++)
        {
            Vector3 pos = activeEnemyAreaPos.transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));
            Instantiate(EnemyPrefab, pos, transform.rotation).transform.SetParent(activeEnemyAreaPos.transform);
        }
    }
}
