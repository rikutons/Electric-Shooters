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
        UnionGameData.OnLimitTimeChanged += ChangeText;
    }

    private void OnDisable()
    {
        UnionGameData.OnLimitTimeChanged -= ChangeText;
    }

    void ChangeText(float limit_time)
    {
        limit_time = (int)limit_time;
        timerText.text = string.Format("{0}:{1:D2}", (int)limit_time / 60, (int)limit_time % 60);
    }
}
