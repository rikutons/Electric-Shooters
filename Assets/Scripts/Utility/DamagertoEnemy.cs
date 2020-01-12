using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagertoEnemy : MonoBehaviour
{
    public float damage { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //ダメージを与える処理
        }
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
