using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //シーン遷移
    public void LoadSceneTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void LoadSceneGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadSceneOption()
    {
        SceneManager.LoadScene("Option");

    }
}