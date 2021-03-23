using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBoom : MonoBehaviour
{
   
    [SerializeField] private GameObject _explosion;
    private Coroutine _coroutine;

    private void Awake()
    {
        _coroutine = StartCoroutine(Stop());
    }

    public IEnumerator Stop()
    {
        yield return new WaitForSeconds(1f);
        _explosion.SetActive(false);
        

    }
}
