using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class UnionGameData : SingletonMonoBehaviour<UnionGameData>
{
    float limit_time;
    static public float LimitTime {
        get { return Instance.limit_time; }
        set {
            Instance.limit_time = value;
            OnLimitTimeChanged(LimitTime);
        }
    }
    static public event Action<float> OnLimitTimeChanged;
}
