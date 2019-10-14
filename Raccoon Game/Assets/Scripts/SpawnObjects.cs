using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject prefabtoSpawn;


    public void Spawn()
    {
        Instantiate(prefabtoSpawn, transform.position, transform.rotation);
        prefabtoSpawn.GetComponent<Rigidbody>().velocity = new Vector3(15000, 0, 0);
    }
}
