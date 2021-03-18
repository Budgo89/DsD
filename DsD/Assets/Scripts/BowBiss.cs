using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowBiss : MonoBehaviour
{
    [SerializeField] private GameObject _bowbis;
    [SerializeField] private GameObject _bow;
    [SerializeField] private GameObject _bowBisPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _bowbis.SetActive(false);
            _bow.SetActive(false);
            _bowBisPlayer.SetActive(true);
        }
    }
}
