using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{

    public float speed = 50.0f;
    public Transform chase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 heading = transform.position - chase.position;
        Vector3 normHeading = Vector3.Normalize(heading);
        float crproduct = Vector3.Cross(transform.position, normHeading).y;
        GetComponent<Rigidbody>().AddTorque(new Vector3(0, crproduct, 0));

    }
}
