using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public Text scoreText;
    public int score;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FBGameScene");
    }

    public void BackMainScene()
    {
        SceneManager.LoadScene("FBMenuScene");
    }

   
}
