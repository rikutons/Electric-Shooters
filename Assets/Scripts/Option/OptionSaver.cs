using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSaver : MonoBehaviour
{
    public void Save()
    {
        PlayerPrefs.SetInt("制限時間", Option.Time.getTime());
        PlayerPrefs.SetInt("感度", Option.Sens.getSensitivity());
        Debug.Log("Data Saved!");
    }
}
