using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            Destroy(this.gameObject);

        GameManager.instance.WaypointsCollected++;
    }
}
