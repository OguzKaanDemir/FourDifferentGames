using PlatformGame.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;

    // static ile sadece bir adet olu�turulmas�n� sa�lad�k.
    // program bitene kadar �al��maya devam eder. 
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;

    private void Awake()
    {
        SingletonThisGameObject();

    }

    private void SingletonThisGameObject()
    {
        // bu class' �n referans�n� Instance' ye aktard�k.
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject); // bu nesneyi yok etme demi� olduk.
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score += 10;
        OnScoreChanged?.Invoke(score);
    }

    public void StartGame()
    {
        // SingletonThisGameObject methodu g�revini bitirmeden RestartGame() ' nin �al��abilmesi i�in  StartCoroutine() yazd�k.
        score = 0;
        StartCoroutine(StartGameAsync());
        Time.timeScale = 1f;
    }

    private IEnumerator StartGameAsync()
    {
        OnSceneChanged?.Invoke();
        // yield return dememizin sebebi method bittikten sonra devam etmesi istenmesidir.
        yield return SceneManager.LoadSceneAsync("JD-Game");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("AllGamesScene");
    }

    public void ReturnMenu()
    {
        OnSceneChanged?.Invoke();
        StartCoroutine(ReturnMenuAsync());
    }

    public IEnumerator ReturnMenuAsync()
    {
        yield return SceneManager.LoadSceneAsync("JD-Menu");
    }

    public static implicit operator GameManager(PG_GameManager v)
    {
        throw new NotImplementedException();
    }
}
