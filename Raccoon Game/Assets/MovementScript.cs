﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Rigidbody player;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        }
    }
}