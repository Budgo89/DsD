using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawne : MonoBehaviour
{
    [SerializeField]
    private GameObject _mob;
    [SerializeField]
    private GameObject _spavn;

    [SerializeField]
    private Transform _pointSpawner;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {        
            print("Ouch:");
        if (other.gameObject.CompareTag("Enemy"))
        {
            print("Ouch:");
            Instantiate(_mob, _pointSpawner.position, _pointSpawner.rotation);
            _spavn.SetActive(false);
        }
    }
}
