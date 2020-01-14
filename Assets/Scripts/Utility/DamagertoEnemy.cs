using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagertoEnemy : MonoBehaviour
{
    public int damage { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //ダメージを与える処理
            EnemyStatusManager enemyStatusManager = other.gameObject.GetComponent<EnemyStatusManager>();
            int score = enemyStatusManager.Damage(damage);
            if (score != 0)
                Destroy(other.gameObject);
            EachPlayerData.Player1_Score += score;
        }
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
