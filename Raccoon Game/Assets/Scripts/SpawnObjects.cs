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
            GameObject spawnedBall = Instantiate(healthySpawn, transform.position, transform.rotation);
            rb = spawnedBall.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(Random.Range(1, 50), Random.Range(1, 50), Random.Range(1, 50)));
        }
        else
        {
            Rigidbody rb;
            GameObject spawnedBall = Instantiate(decayedSpawn, transform.position, transform.rotation);
            rb = spawnedBall.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(Random.Range(1, 50), Random.Range(1, 50), Random.Range(1, 50)));
        }
    }
}
