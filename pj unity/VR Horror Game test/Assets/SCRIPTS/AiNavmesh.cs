using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiNavmesh : MonoBehaviour
{
    NavMeshAgent myAgent;
    public Transform [] waypoints;

    void Awake()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }


    // Start is called before the first frame update
    void Start()
    {
        PickWayPoint();
    }

    // Update is called once per frame
    private void Update()
    {
        if(myAgent.remainingDistance < 1f)
        {
            PickWayPoint();
        }
    }


    void PickWayPoint()
    {
        int randomWPNumber;
        randomWPNumber = Random.Range(0, waypoints.Length);

        myAgent.SetDestination(waypoints[randomWPNumber].position);
    }
}
