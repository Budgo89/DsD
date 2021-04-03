using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _mine;

    [SerializeField] private Transform _pointSpawner;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(_mine, _pointSpawner.position, _pointSpawner.rotation);
    }
}
