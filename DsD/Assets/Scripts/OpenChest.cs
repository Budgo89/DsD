using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private GameObject _obl;
    private Animator _animator;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            //_сhest.SetActive(false);
            var openChest =_animator.GetBool("OpenChest");
            _animator.SetBool("OpenChest", true);
            // _arrows.SetActive(false);
            // _bows.SetActive(false);
            // _bow.SetActive(true);
            // _player.GetComponent<BoomArrow>().enabled = true;
        }

    }
}
