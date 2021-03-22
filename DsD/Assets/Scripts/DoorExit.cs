using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _zoon;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = _door.gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            if (_key.activeSelf == false)
            {
                // _door.SetActive(false);
                _zoon.SetActive(false);
                print("ДВЕРЬ ОТКРЫТА");
                _animator.SetTrigger("OpenDoor");
                
            }
            else
            {
                print("НАЙДИТЕ КЛЮЧ");
            }
        }

    }
}
