using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillSc2 : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MyEnemy>())
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
            gameObject.SetActive(false);
        }

    }
}
