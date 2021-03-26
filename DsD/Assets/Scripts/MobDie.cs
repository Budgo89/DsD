using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobDie : MonoBehaviour
{
    [SerializeField]
    public int _health;
    [SerializeField] private Slider _hp;
    public void Hurt(int damage)
    {
        print("Ouch:" +damage);

        _health -= damage; ;

        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
    public void HP(int damage)
    {
        _hp.value = _health - damage;
    }
}
