using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject healthySpawn, decayedSpawn;


    public void Spawn()
    {
        int randomInt = 0;
        randomInt = Random.Range(0, 24); //20% chance that the object spawned will already be decayed, damaging the player
        if (randomInt < 20)
        {
            //Spawn a decayed object
            Rigidbody rb;
            GameObject spawnedBall = Instantiate(healthySpawn, transform.position, transform.rotation);
            rb = spawnedBall.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(Random.Range(1, 25), Random.Range(1, 25), Random.Range(1, 25)));
        }
        else
        {
            //Spawn a healthy object
            Rigidbody rb;
            GameObject spawnedBall = Instantiate(decayedSpawn, transform.position, transform.rotation);
            rb = spawnedBall.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(Random.Range(1, 25), Random.Range(1, 25), Random.Range(1, 25)));
        }
    }
}
