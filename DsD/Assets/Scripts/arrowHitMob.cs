using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHitMob : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<MyEnemy>();
        if (enemy != null)
        {
            print("Урон");
            enemy.Hurt(_damage);
            enemy.HP(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
