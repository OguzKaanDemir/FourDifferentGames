using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olum : MonoBehaviour
{
    [SerializeField] GameObject _olumPanel;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _carScroll;
    [SerializeField] GameObject _mapScroll;
    [SerializeField] GameObject _startButton;
    [SerializeField] GameObject _exitButton;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _carScroll.SetActive(false);
        _mapScroll.SetActive(false);
        _startButton.SetActive(false);
        _exitButton.SetActive(false);
        _canvas.SetActive(true);
        _olumPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
