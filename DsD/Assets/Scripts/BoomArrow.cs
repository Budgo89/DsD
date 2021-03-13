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
    //private void Start()
    //{
    //    gameObject.GetComponent<BoomArrow>().enabled = false;
    //}
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody p = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            p.velocity = transform.forward * speed;
        }
    }
}
