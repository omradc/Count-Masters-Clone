using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // DetectArea ya çarptığımda hangi EnemyArea da olduğumu bielceğim
        if (other.gameObject.CompareTag("Player"))
        {
           SpawnEnemy.Instance.activeEnemyAreaPos = transform.GetChild(0).gameObject;
           SpawnEnemy.Instance.EnemySPawner();
        }
    }
}
