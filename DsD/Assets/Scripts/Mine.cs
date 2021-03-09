using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] public int _damage;

    //void OnTriggerEnter(Collider other)
    //{
        //// Когда в область тригера попадает что то
        //print("Ouch:");
        //if (other.gameObject.tag == "Enemy")
        //{ // Если это ядро
        //    //Goal.goalMet = true;
        //    //// Изменить альфа канал (увелич. непрозрачность)
        //    //Material mat = GetComponent<Renderer>().material;
        //    //Color c = mat.color;
        //    //c.a = 1;
        //    //mat.color = c;
        //    print("Ouch:");
        //}
    //}



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            print("Ouch:");
        if (other.tag == "Enemy")
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }



    }

}
