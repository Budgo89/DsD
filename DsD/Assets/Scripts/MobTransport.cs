using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTransport : MonoBehaviour
{
    [SerializeField]
    private Transform _mobTransform;

    private void Start()
    {
     //   InvokeRepeating(Update, 2, 10);
        _mobTransform.transform.rotation *= Quaternion.Euler(0, -90, 0);
    }

    private void Update()
    {
        
        _mobTransform.position = Vector3.MoveTowards(_mobTransform.position, transform.position, 2 * Time.deltaTime);
    }
}
