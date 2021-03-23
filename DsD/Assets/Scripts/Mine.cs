using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] 
    public int _damage;
    [SerializeField]
    private GameObject _min;
    public GameObject _explosion;
    private float reloadTimer = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            print("Ouch:");
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            _min.SetActive(false);
            _explosion.SetActive(true);
            _explosion.GetComponent<StopBoom>().enabled = true;
        }
    }

}
