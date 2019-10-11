using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Rigidbody player;
    public float movementSpeed = 2;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position + (Vector3.forward * movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + (Vector3.right * movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position + (Vector3.back * movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + (Vector3.left * movementSpeed * Time.deltaTime));
        }
    }
    //private void OnCollisionEnter(Collision other)
    //{
      //  if (other.gameObject.name == "DecayedFood")
        //    SendMessage("Collision Detected!");
        //Destroy(other);
    //}
}

