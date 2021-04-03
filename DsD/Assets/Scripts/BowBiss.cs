using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BowBiss : MonoBehaviour
{
    [SerializeField] private GameObject _bowInterface;
    [SerializeField] private GameObject _bisBowInterface;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _zone;
    [SerializeField] private GameObject _bisBow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _bowInterface.SetActive(false);
            _bisBowInterface.SetActive(true);
            _bisBow.SetActive(false);
            _hinr.text = "Вы получили Эльфийский лук";
            var _hp = other.gameObject.GetComponent<MyEnemy>();
            if (_hp._health != 5)
            {
                _hp.Hurt(_hp._health - 5);
                other.gameObject.GetComponent<MyEnemy>()._health = 5;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _zone.SetActive(false);
    }
}
