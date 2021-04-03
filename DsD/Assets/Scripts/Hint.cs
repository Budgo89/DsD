using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hint : MonoBehaviour
{
    [SerializeField] private TMP_Text _hinr;

    [SerializeField] private GameObject _zone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = "Подойдете к сундуку и возьмете оружие";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _hinr.text = " ";
            _zone.SetActive(false);
        }
    }
}
