using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGameManager : MonoBehaviour
{   
    [Header("MENU PANEL HEADER")]
    public GameObject _menuPanel;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    #region Menu Methods

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("CFI-GameScene");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("AllGamesScene");
    }
    #endregion
}
