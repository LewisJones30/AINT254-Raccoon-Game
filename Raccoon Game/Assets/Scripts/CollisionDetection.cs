using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    public UnityEvent onCollisionHealthy;
    public UnityEvent onCollisionDecayed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "DefaultFood(Clone)")
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
    }
}
