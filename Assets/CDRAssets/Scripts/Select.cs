using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    [SerializeField] GameObject _redCar;
    [SerializeField] GameObject _blueCar;
    [SerializeField] GameObject _orangeCar;
    [SerializeField] GameObject _redRaceCar;
    // --------------- //
    [SerializeField] GameObject _redCarOyunCamera;
    [SerializeField] GameObject _blueCarOyunCamera;
    [SerializeField] GameObject _orangeCarOyunCamera;
    [SerializeField] GameObject _redRaceCarOyunCamera;
    [SerializeField] GameObject _anaCamera; 
    // --------------- //
    [SerializeField] GameObject _ormanHarita;
    [SerializeField] GameObject _marsHarita;
    [SerializeField] GameObject _otoyolHarita;
    [SerializeField] GameObject _colHarita;
    // -------------- //
    [SerializeField] GameObject _canvas;
    // -------------- //
    private bool _redCarSelected;
    private bool _blueCarSelected;
    private bool _orangeCarSelected;
    private bool _redRaceCarSelected;
    // ------------- //
    private bool _ormanHaritaSelected;
    private bool _marsHaritaSelected;
    private bool _otoyolHaritaSelected;
    private bool _colHaritaSelected;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    #region Harita Seçme Ýþlemleri
    public void SelectOrmanHarita()
    {
        HaritaSetActiveFalse();
        _ormanHaritaSelected = true;
        _marsHaritaSelected = false;
        _otoyolHaritaSelected = false;
        _colHaritaSelected = false;
    }
    public void SelectMarsHarita()
    {
        HaritaSetActiveFalse();
        _ormanHaritaSelected = false;
        _marsHaritaSelected = true;
        _otoyolHaritaSelected = false;
        _colHaritaSelected = false;
    }

    public void SelectOtoyolHarita()
    {
        HaritaSetActiveFalse();
        _ormanHaritaSelected = false;
        _marsHaritaSelected = false;
        _otoyolHaritaSelected = true;
        _colHaritaSelected = false;
    }

    public void SelectColHarita()
    {
        HaritaSetActiveFalse();
        _ormanHaritaSelected = false;
        _marsHaritaSelected = false;
        _otoyolHaritaSelected = false;
        _colHaritaSelected = true;
    }
    #endregion

    #region Araba Seçme Ýþlemleri
    public void SelectRedCar()
    {
        CarSetActiveFalse();
        _redCarSelected = true;
        _blueCarSelected = false;
        _orangeCarSelected = false;
        _redRaceCarSelected = false;

        Time.timeScale = 0f;
    }
    public void SelectBlueCar()
    {
        CarSetActiveFalse();
        _redCarSelected = false;
        _blueCarSelected = true;
        _orangeCarSelected = false;
        _redRaceCarSelected = false;

        Time.timeScale = 0f;
    }
    public void SelectOrangeCar()
    {
        CarSetActiveFalse();
        _redCarSelected = false;
        _blueCarSelected = false;
        _orangeCarSelected = true;
        _redRaceCarSelected = false;

        Time.timeScale = 0f;
    }
    public void SelectRedRaceCar()
    {
        CarSetActiveFalse();
        _redCarSelected = false;
        _blueCarSelected = false;
        _orangeCarSelected = false;
        _redRaceCarSelected = true;

        Time.timeScale = 0f;
    }
    #endregion

    public void StartButton()
    {
        #region Oyun Baþlatma Ýþlemleri
        if (_redCarSelected)
        {
            
            if (_ormanHaritaSelected)
            {
                _redCarOyunCamera.SetActive(true);
                _ormanHarita.SetActive(true);
                _redCar.SetActive(true);
                CarSelected();
            }

            if (_marsHaritaSelected)
            {
                _redCarOyunCamera.SetActive(true);
                _marsHarita.SetActive(true);
                _redCar.SetActive(true);
                CarSelected();
            }

            if (_otoyolHaritaSelected)
            {
                _redCarOyunCamera.SetActive(true);
                _otoyolHarita.SetActive(true);
                _redCar.SetActive(true);
                CarSelected();
            }

            if (_colHaritaSelected)
            {
                _redCarOyunCamera.SetActive(true);
                _colHarita.SetActive(true);
                _redCar.SetActive(true);
                CarSelected();
            }

        }

        if (_blueCarSelected)
        {
            if (_ormanHaritaSelected)
            {
                _blueCarOyunCamera.SetActive(true);
                _ormanHarita.SetActive(true);
                _blueCar.SetActive(true);
                CarSelected();
            }

            if (_marsHaritaSelected)
            {
                _blueCarOyunCamera.SetActive(true);
                _marsHarita.SetActive(true);
                _blueCar.SetActive(true);
                CarSelected();
            }
            if (_otoyolHaritaSelected)
            {
                _blueCarOyunCamera.SetActive(true);
                _otoyolHarita.SetActive(true);
                _blueCar.SetActive(true);
                CarSelected();
            }
            if (_colHaritaSelected)
            {
                _blueCarOyunCamera.SetActive(true);
                _colHarita.SetActive(true);
                _blueCar.SetActive(true);
                CarSelected();
            }
        }

        if (_orangeCarSelected)
        {
            if (_ormanHaritaSelected)
            {
                _orangeCarOyunCamera.SetActive(true);
                _ormanHarita.SetActive(true);
                _orangeCar.SetActive(true);
                CarSelected();
            }

            if (_marsHaritaSelected)
            {
                _orangeCarOyunCamera.SetActive(true);
                _marsHarita.SetActive(true);
                _orangeCar.SetActive(true);
                CarSelected();
            }
            if (_otoyolHaritaSelected)
            {
                _orangeCarOyunCamera.SetActive(true);
                _otoyolHarita.SetActive(true);
                _orangeCar.SetActive(true);
                CarSelected();
            }
            if (_colHaritaSelected)
            {
                _orangeCarOyunCamera.SetActive(true);
                _colHarita.SetActive(true);
                _orangeCar.SetActive(true);
                CarSelected();
            }
        }

        if (_redRaceCarSelected)
        {
            if (_ormanHaritaSelected)
            {
                _redRaceCarOyunCamera.SetActive(true);
                _ormanHarita.SetActive(true);
                _redRaceCar.SetActive(true);
                CarSelected();
            }

            if (_marsHaritaSelected)
            {
                _redRaceCarOyunCamera.SetActive(true);
                _marsHarita.SetActive(true);
                _redRaceCar.SetActive(true);
                CarSelected();
            }
            if (_otoyolHaritaSelected)
            {
                _redRaceCarOyunCamera.SetActive(true);
                _otoyolHarita.SetActive(true);
                _redRaceCar.SetActive(true);
                CarSelected();
            }
            if (_colHaritaSelected)
            {
                _redRaceCarOyunCamera.SetActive(true);
                _colHarita.SetActive(true);
                _redRaceCar.SetActive(true);
                CarSelected();
            }
        }
        #endregion
        Time.timeScale = 1f;
    }

    #region Set Active False Kýsa Halleri
    private void CarSetActiveFalse()
    {
        _redRaceCar.SetActive(false);
        _orangeCar.SetActive(false);
        _blueCar.SetActive(false);
        _redCar.SetActive(false);
    }

    private void HaritaSetActiveFalse()
    {
        _ormanHarita.SetActive(false);
        _marsHarita.SetActive(false);
        _otoyolHarita.SetActive(false);
        _colHarita.SetActive(false);
    }
    #endregion


    private void CarSelected()
    {
        _anaCamera.SetActive(false);
        _canvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("CDR-OyunScene");
        Time.timeScale = 1f;
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("CDR-MenuScene");
    }
}
