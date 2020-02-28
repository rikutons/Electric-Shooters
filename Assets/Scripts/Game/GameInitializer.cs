using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField]
    float first_limit_second;
    void Start()
    {
        float limit_second;
        if(PlayerPrefs.HasKey("制限時間"))
            limit_second = PlayerPrefs.GetInt("制限時間") * 60;
        else
            limit_second = first_limit_second;
        UnionGameData.LimitTime = limit_second;
    }
}
