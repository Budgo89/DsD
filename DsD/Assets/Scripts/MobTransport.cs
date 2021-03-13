using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTransport : MonoBehaviour
{
    [SerializeField]
    private Transform _mobTransform;
    [SerializeField]
    private Transform _punkt1;
    [SerializeField]
    private Transform _punkt2;
    private int punkt;
    private float _distance;
    private void Start()
    {     
        _mobTransform.transform.rotation *= Quaternion.Euler(0, 180, 0);
        punkt = 0;
    }

    private void Update()
    {

        switch (punkt)
        {
            case 0:
                if (_mobTransform != null)
                {
                    _mobTransform.position = Vector3.MoveTowards(_mobTransform.position, _punkt1.position, 2 * Time.deltaTime);
                    _distance = Vector3.Distance(_mobTransform.position, transform.position);
                    if(_distance < 0.5)
                    {
                        punkt = 1;
                    }
                }
                break;
            case 1:
                if (_mobTransform != null)
                {
                    _mobTransform.position = Vector3.MoveTowards(_mobTransform.position, _punkt2.position, 2 * Time.deltaTime);
                    _distance = Vector3.Distance(_mobTransform.position, _punkt2.position);
                    if (_distance < 0.5)
                    {
                        punkt = 0;
                    }
                }
                break;


        }



        
    }
}
