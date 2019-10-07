using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyTimeEvent : MonoBehaviour
{

    public float time = 1;
    public bool repeat = false;
    private void Start()
    {
        if (repeat)
        {
            InvokeRepeating("DestroyEvent", 0, time);
        }
        else
        {
            Invoke("DestroyEvent", time);
        }
    }
    private void DestroyEvent()
    {
        Destroy(gameObject);
    }
}
