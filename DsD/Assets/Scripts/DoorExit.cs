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
    [SerializeField] private AudioSource _audioSource;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = _door.gameObject.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            if (_key.activeSelf == false)
            {
                _hinr.text = "Дверь открыта";
                _animator.SetTrigger("OpenDoor");
                _audioSource.Play();
                Invoke("ZoonOff",2f);
                
            }
            else
                _hinr.text = "Найдите ключ";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
    }

    private void ZoonOff()
    {
        _zoon.SetActive(false);
    }
}
