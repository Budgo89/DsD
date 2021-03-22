using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Сhest : MonoBehaviour
{

    //сундук
    [SerializeField] private GameObject _сhest;
    //стрелы в сундуке
    [SerializeField] private GameObject _arrows;
    //лук в сундуке
    [SerializeField] private GameObject _bows;
    //лук персонажа
    [SerializeField] private GameObject _bow;
    [SerializeField] private GameObject _player;

    [SerializeField] private GameObject _obl;
    
    private Animator _animator;
    
    private void Awake()
    {
        _animator = _сhest.gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _animator.SetTrigger("OpenChest");
            _arrows.SetActive(false);
            _bows.SetActive(false);
            _bow.SetActive(true);
            _player.GetComponent<BoomArrow>().enabled = true;
            _obl.SetActive(false);
        }

    }
}
