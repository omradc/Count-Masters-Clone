using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    Transform target;
    public float speed;
    Rigidbody playerRb;
    void Start()
    {
        target = GameObject.Find("Players").GetComponent<PlayerController>().transform.GetChild(0);
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        Vector3 lookDirection = (target.position - transform.position).normalized;

        playerRb.AddForce(lookDirection * speed);



        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);


            int currrentPlayer = GameObject.Find("Players").GetComponent<PlayerController>().transform.childCount;
            ChangeNumber.playerNumber = currrentPlayer - 1;
            Debug.Log("Şimdiki oyuncu sayısı == " + ChangeNumber.playerNumber);

        }
    }

}
