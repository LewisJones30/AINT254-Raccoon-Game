using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public UnityEvent onCollisionHealthy;
    public UnityEvent onCollisionDecayed;
    public GameObject player;
    public MovementScript movement;
    public Text doublePointsText, doubleSpeedText, invulnerabilityText, spawnerText;
    public ScoringAndHealth scoringScript;
    public bool doubleSpeedActive = false;
    public bool invulnerability = false;
    public Animator glowingAnim;
    [SerializeField]
    private SpawnObjects spawnerScript;
    public AudioSource collectionTone;
    // Start is called before the first frame update
    void Start()
    {
        movement = player.GetComponent<MovementScript>();
        scoringScript = player.GetComponent<ScoringAndHealth>();
        doublePointsText.enabled = false; //Disable text until called
        doubleSpeedText.enabled = false;
        invulnerabilityText.enabled = false;
        glowingAnim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "HealthyFood(Clone)" || other.gameObject.name == "HealthyFood") //Second check is to ensure if it is added in directly it will work
        {

            //Collision Detection - Add to score
            collectionTone.Play();
            Destroy(other.gameObject);
            onCollisionHealthy.Invoke();
        }
        else if (other.gameObject.name == "DecayedFood(Clone)")
        {
            //Collision Detection negative health here
            Destroy(other.gameObject);
            onCollisionDecayed.Invoke();
        }
        else if (other.gameObject.name == "doubleSpeed" || other.gameObject.name == "doubleSpeed(Clone)")
        {
            Destroy(other.gameObject);
            Debug.Log("Powerup detected.");
            StartCoroutine(doubleSpeedPowerup());
        }
        else if (other.gameObject.name == "doublePoints" || other.gameObject.name == "doublePoints(Clone)")
        {
            Destroy(other.gameObject);
            Debug.Log("Double Points activated.");
            StartCoroutine(doublePoints());
        }
        else if (other.gameObject.name == "invulnerability" || other.gameObject.name == "invulnerability(Clone)")
        {
            Destroy(other.gameObject);
            Debug.Log("Invulnerability period has been activated.");
            StartCoroutine(immunity());
        }
        else if (other.gameObject.name == "guaranteedSpawns" || other.gameObject.name == "guaranteedSpawns(Clone)")
        {
            Destroy(other.gameObject);
            Debug.Log("Guaranteed spawns active");
            StartCoroutine(guaranteedSpawns());
        }
            IEnumerator doublePoints() //Double points script
        {
            scoringScript.doublePoints = true;
            doublePointsText.text = "Double points active!";
            doublePointsText.enabled = true;
            doublePointsText.color = Color.green;
            yield return new WaitForSeconds(20); //Stay active for 20 seconds. Manually adjusted here.
            scoringScript.doublePoints = false;
            doublePointsText.enabled = false;
        }
        IEnumerator doubleSpeedPowerup() //Double speed script
        {
            if (doubleSpeedActive == true)
            {
                yield break; //prevents the speed being run more than once, as this creates an uncontrollable playeroh y
            }
            else
            {
                doubleSpeedActive = true;
                float doublespeed = movement.movementSpeed * 2;
                movement.movementSpeed = doublespeed;
                doubleSpeedText.text = "Double speed active!";
                doubleSpeedText.enabled = true;
                doubleSpeedText.color = Color.cyan;
                yield return new WaitForSeconds(20); //20 second activation time for double speed. Manually adjusted here.
                movement.movementSpeed = doublespeed / 2;
                doubleSpeedText.enabled = false;
                doubleSpeedActive = false;
            }

        }
        IEnumerator immunity()
        {
            scoringScript.invulnerability = true;
            invulnerabilityText.text = "You are currently immune to damage!";
            invulnerabilityText.enabled = true;
            invulnerabilityText.color = Color.yellow;
            glowingAnim.enabled = true;
            yield return new WaitForSeconds(20);
            invulnerabilityText.enabled = false;
            scoringScript.invulnerability = false;
            glowingAnim.enabled = false;

        }
        IEnumerator guaranteedSpawns()
        {
            spawnerScript.powerup = true;
            spawnerText.text = "For 10 seconds, all spawns are guaranteed to be healthy";
            spawnerText.enabled = true;
            yield return new WaitForSeconds(10);
            spawnerText.enabled = false;
            spawnerScript.powerup = false;
        }


    }
}
