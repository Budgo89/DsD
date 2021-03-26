using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _zoon;
    [SerializeField] private TMP_Text _hinr;
    
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
                _hinr.text = "Дверь открыта";
                _zoon.SetActive(false);
                _animator.SetTrigger("OpenDoor");
                
            }
            else
            {
                _hinr.text = "Найдите ключ";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
    }
}
