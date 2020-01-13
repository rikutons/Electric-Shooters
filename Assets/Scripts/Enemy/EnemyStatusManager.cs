using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusManager : MonoBehaviour
{
    [SerializeField]
    private int enemyID;

    int HP;
    void Start()
    {
        HP = EnemyData.HitPoints[enemyID];
    }

    public int Damage(int damage)
    {
        HP -= damage;
        if(HP <= 0)
            return EnemyData.Scores[enemyID];
        return 0;
    }
}
