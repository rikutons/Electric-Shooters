using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField]
    float first_limit_second;
    void Start()
    {
        UnionGameData.LimitTime = first_limit_second;
    }
}
