using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private float interval;
    [SerializeField]
    private GameObject[] enemyPrefabs;
    [SerializeField]
    private Vector3 plusLimitPos;
    [SerializeField]
    private Vector3 minusLimitPos;

    private float time;
    private void Generate()
    {
        var pos = new Vector3(
            Random.Range(minusLimitPos.x, plusLimitPos.x),
            Random.Range(minusLimitPos.y, plusLimitPos.y),
            Random.Range(minusLimitPos.z, plusLimitPos.z)
        );
        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], pos, Quaternion.identity);
    }

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= interval)
        {
            time = 0;
            Generate();
        }
    }
}
