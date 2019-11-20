using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DecayFood : MonoBehaviour
{

    public float time = 1;
    public bool repeat = false;
    public GameObject decayedFood;

    private void Start()
    {
        time = Random.Range(1f, 10f);
        Debug.Log("Time to decay:");
        if (repeat == true)
        {
            InvokeRepeating("TransformEvent", 0, time); //Repeats until time reaches time specified
        }
        else
        {
            Invoke("TransformEvent", time); //Invokes the transform event
        }
    }
    private void TransformEvent()
        //Converts the food into the decayed version of food, damaging the player
    {
            Instantiate(decayedFood, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
