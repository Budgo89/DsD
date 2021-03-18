using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _zoon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _key.SetActive(false);
            _zoon.SetActive(false);
            print("ВЫ ПОДОБРАЛИ КЛЮЧ. НАЙДИТЕ ДВЕРЬ");
        }

        
    }
}

