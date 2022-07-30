using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMotion : MonoBehaviour
{
    [SerializeField] private bool isMotioning;
    [SerializeField] private float max;
    [SerializeField] private float min;
    [SerializeField] private float motionTime;
    static float t = 0;

    private void Update()
    {
        if (isMotioning == true)
        {
            transform.position = new Vector3(Mathf.Lerp(min, max, t), transform.position.y, transform.position.z);
            t += Time.deltaTime / motionTime;
            if (t > 1.0f)
            {
                float temp = max;
                max = min;
                min = temp;
                t = 0.0f;
            }
        }
    }
}
