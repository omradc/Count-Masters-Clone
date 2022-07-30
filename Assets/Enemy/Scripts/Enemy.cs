using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public Vector3 target2;
    public float followSpeed;
    public float groupSpeed;
    Rigidbody enemyRb;
    public static bool isFollowing;
    
    void Start()
    {
        target = GameObject.Find("Players").GetComponent<PlayerController>().transform.GetChild(0); // player ın merkezi
        target2 = SpawnEnemy.Instance.activeEnemyAreaPos.transform.position; // aktif düşman alanının merkezi
        enemyRb = GetComponent<Rigidbody>();
    }
  

    void Update()
    {
        if (isFollowing==true)
        {
            Vector3 lookDirection = (target.position - transform.position).normalized;

            enemyRb.AddForce(lookDirection * followSpeed);
        }
        if (isFollowing==false)
        {
            Vector3 lookDirection2 = (target2 - transform.position).normalized;

            enemyRb.AddForce(lookDirection2 * groupSpeed);
        }
        

    }
}
