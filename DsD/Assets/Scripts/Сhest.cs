using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сhest : MonoBehaviour
{

    //сундук
    [SerializeField]
    private GameObject _сhest;
    //стрелы в сундуке
    [SerializeField]
    private GameObject _arrows;
    //лук в сундуке
    [SerializeField]
    private GameObject _bows;
    //лук персонажа
    [SerializeField]
    private GameObject _bow;
    [SerializeField]
    private GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            _сhest.SetActive(false);
            _arrows.SetActive(false);
            _bows.SetActive(false);
            _bow.SetActive(true);
            _player.GetComponent<BoomArrow>().enabled = true;
        }

    }
}
