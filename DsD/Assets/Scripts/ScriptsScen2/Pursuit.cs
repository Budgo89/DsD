using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pursuit : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    // радиус стрельбы
    [SerializeField]
    private float _radius;
    private float _distance;
    private NavMeshAgent _navMesh;

    private void Awake()
    {
        _navMesh = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        _distance = Vector3.Distance(_player.position, transform.position);
        if (_distance <= _radius)
        {/*
            var relativePos = _player.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;*/
            _navMesh.destination = _player.position;
        }
    }


}
