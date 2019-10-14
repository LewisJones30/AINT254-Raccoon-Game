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
            rb.AddRelativeForce(new Vector3(0.0f, 0.0f, movementSpeed * 10));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, (Input.GetAxis("Horizontal")) * 2, 0.0f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddRelativeForce(new Vector3(0.0f, 0.0f, movementSpeed * -10));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, (Input.GetAxis("Horizontal")) * 2, 0.0f));
        }
        //Detects if the key has been lifted. Immediately stops the rigidbody's force to better simulate player movement.
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.Sleep();
        }
    }
    //private void OnCollisionEnter(Collision other)
    //{
      //  if (other.gameObject.name == "DecayedFood")
        //    SendMessage("Collision Detected!");
        //Destroy(other);
    //}
}

