using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BowBiss : MonoBehaviour
{
    [SerializeField] private GameObject _bowbis;
    [SerializeField] private GameObject _bow;
    [SerializeField] private GameObject _bowBisPlayer;
    [SerializeField] private GameObject _bowInterface;
    [SerializeField] private GameObject _bisBowInterface;
    [SerializeField] private TMP_Text _hinr;
    [SerializeField] private GameObject _zone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _bowbis.SetActive(false);
            _bow.SetActive(false);
            _bowBisPlayer.SetActive(true);
            _bowInterface.SetActive(false);
            _bisBowInterface.SetActive(true);
            _hinr.text = "Вы получили Эльфийский лук";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _zone.SetActive(false);
    }
}
