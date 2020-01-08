using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EachPlayerData : SingletonMonoBehaviour<EachPlayerData>
{
    float score;
    static public float Score
    {
        get { return Instance.score; }
        set
        {
            Instance.score = value;
            OnScoreChanged(Score);
        }
    }
    static public event Action<float> OnScoreChanged;
}
