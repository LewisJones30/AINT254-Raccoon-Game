using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
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
        }
        else if (other.gameObject.name == "DecayedFood(Clone)")
        {
            //Collision Detection negative health here
            Destroy(other.gameObject);
        }
    }
}
