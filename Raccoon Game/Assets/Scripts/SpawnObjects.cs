using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject healthySpawn, decayedSpawn;


    public void Spawn()
    {
        int randomInt = 0;
        randomInt = Random.Range(0, 9);
        if (randomInt < 5)
        {
            Rigidbody rb;
            Instantiate(healthySpawn, transform.position, transform.rotation);
            rb = this.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(Random.Range(1, 1500), Random.Range(1, 1500), Random.Range(1, 1500)));
        }
        else
        {
            Instantiate(decayedSpawn, transform.position, transform.rotation);
            decayedSpawn.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(1,1500), Random.Range(1,1500), Random.Range(1,1500)));
        }
    }
}
