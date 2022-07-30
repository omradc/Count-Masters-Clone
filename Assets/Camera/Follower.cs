using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform player;
    private void LateUpdate()
    {
        float cameraZPos = transform.position.z;
        cameraZPos = player.position.z - 25;

        transform.position = new Vector3(0, 20, cameraZPos);
    }
}
