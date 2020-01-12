using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EachPlayerData : SingletonMonoBehaviour<EachPlayerData>
{
    int player1_Score;
    static public int Player1_Score
    {
        get { return Instance.player1_Score; }
        set
        {
            Instance.player1_Score = value;
            OnPlayer1_ScoreChanged(Player1_Score);
        }
    }
    static public event Action<int> OnPlayer1_ScoreChanged;

    int player2_Score;
    static public int Player2_Score
    {
        get { return Instance.player2_Score; }
        set
        {
            Instance.player2_Score = value;
            OnPlayer2_ScoreChanged(Player2_Score);
        }
    }
    static public event Action<int> OnPlayer2_ScoreChanged;
}
