using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
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
    [SerializeField] private GameObject _door;
    
    [SerializeField] private TMP_Text _hinr;
    
    private Animator _animator;
    private Animator _animatorDoor;
    
    private void Awake()
    {
        _animator = _сhest.gameObject.GetComponent<Animator>();
        _animatorDoor = _door.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = "Стоит осмотреться перед тем как идти дальше";
            _animator.SetTrigger("OpenChest");
            _arrows.SetActive(false);
            _bows.SetActive(false);
            _bow.SetActive(true);
            _player.GetComponent<BoomArrow>().enabled = true;
            _animatorDoor.SetTrigger("OpenDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _obl.SetActive(false);
    }
}
