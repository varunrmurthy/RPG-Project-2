using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    #region unity_Function;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    #endregion

    #region Scene_transitions
    public void startGame()
    {
        SceneManager.LoadScene("Field");
    }
    public void winGame()
    {
        SceneManager.LoadScene("WinScene");
    }
    public void loseGame()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void goToMainMenu()
    {
        SceneManager.LoadScene("TitleScene");

    }
    public void startBattle()
    {
        SceneManager.LoadScene("battlescene2");
    }

    #endregion
}
