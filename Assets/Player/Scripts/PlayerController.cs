using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedX;
    public float speedZ;
    private bool moveForward;
    [HideInInspector] public float X;
    [SerializeField] private GameObject restartButton;
    private void Start()
    {
        moveForward = true;
        restartButton.SetActive(false);
    }
    void Update()
    {
        if (moveForward)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speedZ);
        }

        //Dokunmatik kontroller
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            X = finger.deltaPosition.x;
            transform.position += new Vector3(X, 0, 0) * Time.deltaTime * speedX;
        }


        // Ekranda oyuncu kalmayınca oyunu bitir.
        if (ChangeNumber.playerNumber == 0)
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
        }


        //PC kontrol
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * speedX * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * speedX * Time.deltaTime);
        //}
    }
}
