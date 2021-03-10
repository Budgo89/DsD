using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vert : MonoBehaviour
{
    [SerializeField]
    public Transform _player;
    [SerializeField]
    public Vector3 _player1;
    [SerializeField]
    public Transform _VertStat;

    // Update is called once per frame
    void Update()
    {
        //float angle = Quaternion.Angle(_player.rotation, _VertStat.rotation);
        //float angle = Vector3.Dot(_player.position.normalized, _VertStat.position.normalized);
        //print(angle);
        //if (angle != 90 )
    }
}
