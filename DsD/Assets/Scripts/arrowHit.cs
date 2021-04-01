using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{
    private int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("BowInterface") == true)
        {
            _damage = 1;
        }
        else if (GameObject.Find("BISBowInterface") == true)
        {
            _damage = 3;
        }
        var enemy = other.GetComponent<MobKill>();
        if (enemy != null)
        {
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
