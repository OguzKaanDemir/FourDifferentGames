using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] GameObject _winPanel;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _arabaScroll;
    [SerializeField] GameObject _haritaScroll;
    [SerializeField] GameObject _startButton;
    [SerializeField] GameObject _exitButton;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        _arabaScroll.SetActive(false);
        _haritaScroll.SetActive(false);
        _startButton.SetActive(false);
        _exitButton.SetActive(false);
        _winPanel.SetActive(true);
        _canvas.SetActive(true);
    }
}
