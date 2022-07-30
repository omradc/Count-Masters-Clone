using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayers : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Child Player"))
        {
            Destroy(collision.gameObject);
            ChangeNumber.playerNumber--;
        }
    }
}
