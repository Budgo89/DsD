using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTurelKilAnim : MonoBehaviour
{
    [SerializeField] private GameObject _mobTurell;



    private void Update()
    {
        var enemy = _mobTurell.gameObject.GetComponent<MobKill>()._health;
        if (enemy <= 0)
            _mobTurell.GetComponent<MobTurel>().enabled = false;
    }
}
