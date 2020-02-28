using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextChanger : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private void OnEnable()
    {
        EachPlayerData.OnScoreChanged += ChangeText;
    }

    private void OnDisable()
    {
        EachPlayerData.OnScoreChanged -= ChangeText;
    }

    void ChangeText(int score)
    {
        scoreText.text = string.Format("Score : {0}", score);
    }
}
