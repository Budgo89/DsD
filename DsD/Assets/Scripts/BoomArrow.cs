using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomArrow : MonoBehaviour
{
    [SerializeField]
    public Rigidbody projectile;
    [SerializeField]
    public float speed = 4;
    [SerializeField]
    public Transform _arrowSpavner;
   
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody position = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            position.velocity = transform.forward * speed;
        }
    }
}
