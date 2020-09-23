using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public int currentWaypoint;

    public float speed;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Waypoints.waypoints[currentWaypoint].position);
        if (agent.remainingDistance <= .2f)
        {
            currentWaypoint++;
            if (currentWaypoint == Waypoints.waypoints.Length)
            {
                Destroy(gameObject);
            }
            agent.SetDestination(Waypoints.waypoints[currentWaypoint].position);
        }
    }

}
