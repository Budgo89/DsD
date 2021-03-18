using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
