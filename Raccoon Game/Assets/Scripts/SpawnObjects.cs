﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject healthySpawn, decayedSpawn, doublePoints, doubleSpeed, invulnerability, guaranteedspawn;
    public bool powerup = false;


    public void Spawn()
    {
        if (powerup == true)
        {
            spawnObject(healthySpawn);
            return;
        }
        int randomInt = 0;
        randomInt = Random.Range(1, 100); //20% chance that the object spawned will already be decayed, damaging the player
        /*
         * Breakdown of spawning table:
         * 1 - 20 = decayed spawn (20% chance)
         * 21 - 95 = Healthy spawn (75% chance)
         * 96 - 100 = Powerup spawn (5% chance, then split evenly for each powerup).
         * 
         */
        if (randomInt < 20)
        {
            //Spawn a decayed object
            spawnObject(decayedSpawn);
        }
        else if (randomInt < 95)
        {
            //Spawn a healthy object
            spawnObject(healthySpawn);
        }
        else //Roll of 96-100, powerup table is instead triggered
        {
            int powerupint = Random.Range(1, 100); //Select a second integer between 1 and 100 so it can be easily split. For future development, this can be changed to the number of powerups.
            /*
             * Breakdown of current spawning table:
             * 25% chance of all of the following powerups:
             * Double Points
             * Double Speed
             * Guaranteed Healthy Spawns
             * A period of invulnerability
             */
            if (powerupint < 25) //Currently four powerups
            {
                spawnObject(doublePoints);
            }
            else if (powerupint < 50)
            {
                spawnObject(doubleSpeed);
            }
            else if (powerupint < 75)
            {
                spawnObject(invulnerability);
            }
            else
            {
                spawnObject(guaranteedspawn);
            }

        }
    }
    void spawnObject(GameObject objectToSpawn)
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation) as GameObject;
        spawnedObject.GetComponent<Rigidbody>().AddForce(Vector3.up * Random.Range(1, 20));
    }
}
