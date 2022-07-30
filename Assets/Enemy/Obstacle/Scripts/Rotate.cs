using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotateDirection;
    public Vector3 swingDirection;


    [SerializeField] private bool isRotateing;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private bool isSwinging;
    [SerializeField] private float swingStartDegrees;
    [SerializeField] private float swingEndDegrees;
    [SerializeField] private float swingTime;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRotateing == true)
        {
            transform.Rotate(rotateDirection * rotateSpeed);
        }

        if (isSwinging == true)
        {
            float t = Mathf.PingPong(Time.time / swingTime, 1);
            transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, 0, swingStartDegrees), Quaternion.Euler(0, 0, swingEndDegrees), t);
        }
    }
}
