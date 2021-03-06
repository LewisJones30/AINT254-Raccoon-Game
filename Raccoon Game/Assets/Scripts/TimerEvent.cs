﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{

    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;
    private void Start()
    {
        time = Random.Range(10f, 20f);
        Debug.Log("Time to spawn: " + time);
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }
    private void OnTimerComplete()
    {
        onTimerComplete.Invoke();
    }
}
