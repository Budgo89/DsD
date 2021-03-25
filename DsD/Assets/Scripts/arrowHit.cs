using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHit : MonoBehaviour
{
    [SerializeField]
    public int _damage;

    public void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("bowPlayer") == true)
        {
            _damage = 1;
        }
        else if (GameObject.Find("bowBissPlayer") == true)
        {
            _damage = 3;
        }
        var enemy = other.GetComponent<MobKill>();
        if (enemy != null)
        {
            print("Попадание");
            print("Урон");
            enemy.Hurt(_damage);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
