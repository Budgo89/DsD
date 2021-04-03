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
    [SerializeField] private GameObject _bowInterface;
    [SerializeField] private GameObject _bowPlayer;
    [SerializeField] private GameObject _aim;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private AudioSource _audioSource;
    
    private Animator _animator;
    private Animator _animatorDoor;
    
    private void Awake()
    {
        _animator = _сhest.gameObject.GetComponent<Animator>();
        _animatorDoor = _door.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = "Вы получили лук, но стоит осмотреться перед тем как идти дальше";
            _animator.SetTrigger("OpenChest");
            _arrows.SetActive(false);
            _bows.SetActive(false);
            _bow.SetActive(true);
            _player.GetComponent<BoomArrow>().enabled = true;
            _animatorDoor.SetTrigger("OpenDoor");
            _bowInterface.SetActive(true);
            _bowPlayer.SetActive(true);
            _aim.SetActive(true);
            _audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _obl.SetActive(false);
    }
}
