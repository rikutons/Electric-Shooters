using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2_ScoreTextChanger : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private void OnEnable()
    {
        EachPlayerData.OnPlayer2_ScoreChanged += ChangeText;
    }

    private void OnDisable()
    {
        EachPlayerData.OnPlayer2_ScoreChanged -= ChangeText;
    }

    void ChangeText(int score)
    {
        scoreText.text = string.Format("Score : {0}", score);
    }
}
