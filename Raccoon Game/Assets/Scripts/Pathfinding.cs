using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] navigationPoints;
    private NavMeshAgent nav;
    private int destinationPoint;
    private GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!nav.pathPending && nav.remainingDistance < 1f)
        {
            var targetPosition = nav.pathEndPosition;
            var targetPoint = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
            var direction = (targetPoint - transform.position).normalized;
            var lookRotation = Quaternion.LookRotation(direction);
            lookRotation *= Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);


           //transform.GetChild(0).transform.rotation = transform.rotation;
           //transform.GetChild(0).transform.position = transform.position;

            MovePoint();
        }
        else
        {

        }
    }
    void MovePoint()
    {
        if (navigationPoints.Length == 0)
        {
            return;
        }
        nav.destination = navigationPoints[destinationPoint].position;
        destinationPoint = (destinationPoint + 1) % navigationPoints.Length;
 
    }
}
