using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    public int m_CurrentWaypointIndex;
    private Animator _amin;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints[0].position);
        _amin = GetComponent<Animator>();
    }

    void Update ()
    {
        if(_amin.speed >= 0.5)
        {
            _amin.SetBool("Strafe", true);
        }
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {            
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
    }
}
