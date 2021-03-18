using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobPatrolv2 : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    
    [SerializeField]
    private Transform _player;
    // радиус стрельбы
    [SerializeField]
    private float _radius;
    private float _distance;

    int m_CurrentWaypointIndex;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
        if (_player != null)
        {
            _distance = Vector3.Distance(_player.position, transform.position);
            if (_distance <= _radius)
            {
                var relativePos = _player.position - transform.position;
                var rotation = Quaternion.LookRotation(relativePos);
                transform.rotation = rotation;
            }
            else if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
            {
                m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
                navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
            }
        }
        
    }
}
