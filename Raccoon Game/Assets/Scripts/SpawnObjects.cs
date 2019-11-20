using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject healthySpawn, decayedSpawn, doublePoints, doubleSpeed;


    public void Spawn()
    {
        int randomInt = 0;
        randomInt = Random.Range(1, 100); //20% chance that the object spawned will already be decayed, damaging the player
        /*
         * Breakdown of random ints:
         * 1 - 20 = decayed spawn (20% chance)
         * 21 - 95 = Healthy spawn (75% chance)
         * 96 - 100 = Powerup spawn (5% chance, then split evenly for each powerup).
         * 
         */
        if (randomInt < 20)
        {
            //Spawn a healthy object
            GameObject spawnedBall = Instantiate(decayedSpawn, transform.position + new Vector3(10,10,10), transform.rotation) as GameObject;
            spawnedBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * Random.Range(1, 10));
        }
        else if (randomInt < 95)
        {
            //Spawn a decayed object
            GameObject spawnedBall = Instantiate(healthySpawn, transform.position, transform.rotation) as GameObject;
            spawnedBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * Random.Range(1, 10));
        }
        else //Roll of 96-100, powerup table is instead triggered
        {
            int powerupint = Random.Range(1, 100); //Select a second integer between 1 and 100 so it can be easily split. For future development, this can be changed to the number of powerups.
            if (powerupint < 50)
            {
                GameObject spawnedBall = Instantiate(doublePoints, transform.position, transform.rotation) as GameObject;
                spawnedBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * Random.Range(1, 10));
            }
            else
            {
                GameObject spawnedBall = Instantiate(doubleSpeed, transform.position, transform.rotation) as GameObject;
                spawnedBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * Random.Range(1, 10));
            }
        }
    }
}
