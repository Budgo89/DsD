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
    private Animator _amin;
    [SerializeField] private GameObject _sword;

    private void Awake()
    {
        _navMesh = GetComponent<NavMeshAgent>();
        _amin = GetComponent<Animator>();
    }
    
    private void Update()
    {
        _distance = Vector3.Distance(_player.position, transform.position);
        if (_distance <= _radius && _distance > 2)
        {
            _navMesh.speed = 3f;
            _navMesh.destination = _player.position;
        }
        else
            _navMesh.speed = 1.5f;

        var downward = _amin.GetBool("Downward");
        
        if (_distance <= 2 && downward == false)
        {
            StartAttack();
            Invoke("Attack", 4f);
            Invoke("StopAttack", 5f);
        }
    }

    private void StartAttack()
    {
        _amin.SetBool("Downward",true);
    }

    private void Attack()
    {
        _sword.SetActive(true);
    }

    private void StopAttack()
    {
        _amin.SetBool("Downward",false);
        _sword.SetActive(false);
        
    }

}
