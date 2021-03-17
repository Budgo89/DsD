using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitMob : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            print("Попадание");
            print("Урон");
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }

    }
}
