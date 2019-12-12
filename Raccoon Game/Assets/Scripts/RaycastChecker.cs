using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public int raycastLength;
    RaycastHit hit;
    Ray raycast;
    public GameObject player;
    private ScoringAndHealth healthscript;
    [SerializeField]
    private Text warningText;
    public float defaultTimeToBeHit;
    private float time = 0f;
    private GameObject other;

    private bool hitInLast10Seconds = false;
    void Start()
    {
        healthscript = player.GetComponent<ScoringAndHealth>();
        warningText.enabled = false;
        time = defaultTimeToBeHit;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.back);
        if (Physics.SphereCast(transform.position, 8, forward * raycastLength, out hit))
        {
            //Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "Model")
            {
                warningText.enabled = true;
                warningText.text = "WARNING: Damage inflicted in: " + time + " seconds";
                Debug.Log("Collision detected.");
                time = time - Time.deltaTime;
                if (time < 0.01)
                {

                    healthscript.DamagePlayer();
                    Debug.Log("Player damaged!");
                    time = 10f;
                    hitInLast10Seconds = true;
                }

            }
            else if (hit.collider.gameObject.name == "HealthyFood")
            {
                Destroy(other);
                Debug.Log("Food destroyed!");
            }
            else
            {
                warningText.enabled = false;
                if (hitInLast10Seconds == false)
                {
                    time = defaultTimeToBeHit;
                }
                else if (time <= defaultTimeToBeHit) //If the time remaining is equal to the hitinlast10seconds.
                {
                    hitInLast10Seconds = false;
                }
                else //Continue timer down afterwards, until the time remaining hits the hitinlast10seconds. This is to ensure the player is not killed instantly.
                {
                    time = time - Time.deltaTime;
                }

            }
        }
    }
}
