using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _zoon;
    [SerializeField] private TMP_Text _hinr;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _key.SetActive(false);
            _hinr.text = "Вы подобрали ключ. Найдите дверь.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _hinr.text = " ";
        _zoon.SetActive(false);
    }
}

