using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomMine : MonoBehaviour
{
    [SerializeField]
    public Rigidbody projectile;
   //[SerializeField]
    //public float speed = 4;
    [SerializeField]
    public Transform _arrowSpavner;
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody p = Instantiate(projectile, _arrowSpavner.position, _arrowSpavner.rotation);
            //p.velocity = transform.forward * speed;
        }
    }
}
