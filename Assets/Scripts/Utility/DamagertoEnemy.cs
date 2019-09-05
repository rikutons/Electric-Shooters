using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagertoEnemy : MonoBehaviour
{
    public float damage { get; set; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            //ダメージを与える処理
        }
        Destroy(gameObject);
    }
}
