using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawne : MonoBehaviour
{
    [SerializeField]
    private GameObject _mob;
    [SerializeField]
    private GameObject _spavn;

    //[SerializeField]
    //private Transform _pointSpawner;
    //Дверь
    [SerializeField]
    private GameObject _Door;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {        
            print("ПОЯВИЛСЯ БОСС");
        if (other.gameObject.CompareTag("Enemy"))
        {            
            //Instantiate(_mob, _pointSpawner.position, _pointSpawner.rotation);
            _spavn.SetActive(false);
            _Door.SetActive(false);
            _mob.SetActive(true);
        }
    }
}
