using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicSlime : MonoBehaviour
{
    
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        print("touch");
    }

}
