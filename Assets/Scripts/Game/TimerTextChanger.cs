using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTextChanger : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    private void OnEnable()
    {
        UnionGameData.OnLimitTimeChanged += ChangeTimer;
    }

    private void OnDisable()
    {
        UnionGameData.OnLimitTimeChanged -= ChangeTimer;
    }

    void ChangeTimer(float limit_time)
    {
        limit_time = (int)limit_time;
        timerText.text = string.Format("{0}:{1}", (int)limit_time / 60, (int)limit_time % 60);
    }
}
