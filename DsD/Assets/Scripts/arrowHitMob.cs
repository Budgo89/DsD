using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowHitMob : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            print("Попадание");
        if (other.tag == "Enemy")
        {
            print("Урон");
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }

    }
}
