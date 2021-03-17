using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MobKill>())
        {
             print("Попадание");
            print("Урон");
            var enemy = other.GetComponent<MobKill>();
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
