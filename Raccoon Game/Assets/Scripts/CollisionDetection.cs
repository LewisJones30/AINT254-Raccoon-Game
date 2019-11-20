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
    public Text doublePointsText, doubleSpeedText;
    public ScoringAndHealth scoringScript;
    public bool doubleSpeedActive = false;
    // Start is called before the first frame update
    void Start()
    {
        movement = player.GetComponent<MovementScript>();
        scoringScript = player.GetComponent<ScoringAndHealth>();
        doublePointsText.enabled = false; //Disable text until called
        doubleSpeedText.enabled = false;
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
        IEnumerator doublePoints() //Double points script
        {
            scoringScript.doublePoints = true;
            doublePointsText.text = "Double points active!";
            doublePointsText.enabled = true;
            doublePointsText.color = Color.green;
            yield return new WaitForSeconds(10); //Stay active for 10 seconds. Manually adjusted here.
            scoringScript.doublePoints = false;
            doublePointsText.enabled = false;
        }
        IEnumerator doubleSpeedPowerup() //Double speed script
        {
            if (doubleSpeedActive == true)
            {
                yield break;
            }
            else
            {
                doubleSpeedActive = true;
                float doublespeed = movement.movementSpeed * 2;
                movement.movementSpeed = doublespeed;
                doubleSpeedText.text = "Double speed active!";
                doubleSpeedText.enabled = true;
                doubleSpeedText.color = Color.cyan;
                yield return new WaitForSeconds(10); //10 second activation time for double speed. Manually adjusted here.
                movement.movementSpeed = doublespeed / 2;
                doubleSpeedText.enabled = false;
                doubleSpeedActive = false;
            }

        }


    }
}
