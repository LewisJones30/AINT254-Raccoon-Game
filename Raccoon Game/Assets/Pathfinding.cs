using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] navigationPoints;
    private NavMeshAgent nav;
    private int destinationPoint;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!nav.pathPending && nav.remainingDistance < 1f)
        {
            MovePoint();
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
