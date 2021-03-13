using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowHit : MonoBehaviour
{
    //public int _damage;

    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mob"))
            print("Попадание");
        if (other.tag == "Mob")
        {
            print("Урон");
            var enemy = other.GetComponent<MobKill>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
