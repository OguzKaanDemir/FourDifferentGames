using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FBGameScene");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("AllGamesScene");
    }
}
