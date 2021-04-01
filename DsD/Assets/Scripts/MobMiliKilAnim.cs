using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobMiliKilAnim : MonoBehaviour
{
    [SerializeField] private GameObject _mobMili;
    [SerializeField] private NavMeshAgent _navMesh;
    private void Awake()
    {
        _navMesh = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        var enemy = _mobMili.gameObject.GetComponent<MobKill>()._health;
        if (enemy <= 0)
        {
            _mobMili.GetComponent<Pursuit>().enabled = false;
            _navMesh.speed = 0;
        }
    }
}
