using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobDie : MonoBehaviour
{
    [SerializeField]
    public int _health;
    [SerializeField] private Slider _hp;
    private Animator _animator;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void Hurt(int damage)
    {
        _health -= damage; ;

        if (_health <= 0)
        {
            _animator.SetTrigger("Kill1");
            Invoke("Die",5);
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
    public void HP(int damage)
    {
        _hp.value = _health - damage;
    }


}
