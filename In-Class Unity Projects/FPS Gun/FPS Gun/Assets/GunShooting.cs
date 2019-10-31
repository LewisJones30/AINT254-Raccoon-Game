using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{

    public Rigidbody bullet;
    private int bulletDelay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            bulletDelay = bulletDelay + 1;
            if (bulletDelay == 10)
            {
                Rigidbody clone;
                clone = Instantiate(bullet, transform.position, transform.rotation);
                clone.velocity = transform.TransformDirection(Vector3.up * 50);

                bulletDelay = 0;
            }

        }
        else
        {

        }
    }
}
