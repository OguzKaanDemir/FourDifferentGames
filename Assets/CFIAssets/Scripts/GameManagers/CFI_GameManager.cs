using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CFI_GameManager : MonoBehaviour
{
    [SerializeField] BasketMove _velocity;
    [SerializeField] HamburgerSpawner _newValue;
    [SerializeField] HotdogSpawner _newValue1;
    [SerializeField] Basket _basket;
    public GameObject _shop;
    public GameObject _effects;
    public GameObject _speedUpButton;
    public GameObject _yavaslatmaButton;
    public GameObject _ExpansionButton;
    public GameObject _movePanel;
    private int _isOpen = 1;
    private int _speedSinir = 0;
    private int _yavaslatSinir = 0;
    private int _genisletSinir = 0;
    private bool _isSpeedFinish;
    private bool _isYavaslatFinish;
    private bool _isGenisletFinish;

    private void Update()
    {
        ShopSceneKapat();
    }

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Time.timeScale = 1f;
        _velocity = FindObjectOfType<BasketMove>();
        _newValue = FindObjectOfType<HamburgerSpawner>();
        _basket = FindObjectOfType<Basket>();
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("CFI-GameScene");
    }

    public void BackMenuButton()
    {
        SceneManager.LoadScene("CFI-MenuScene");
    } 

    public void EffectButton()
    {
        if (_isOpen == 1)
        {
            _movePanel.SetActive(false);
            Time.timeScale = 0f;
            _effects.SetActive(true);
            _isOpen++;
        }
        else
        {
            _movePanel.SetActive(true);
            Time.timeScale = 1f;
            _effects.SetActive(false);
            _isOpen--;
        }
    }

    public void SpeedUp()
    {
        if (_speedSinir < 3 && _basket.point >= 50)
        {
            _basket.point -= 50;
            _basket.PointTextUpdate(_basket.point);
            _velocity.velocity += 0.5f;
            _speedSinir++;
            if(_speedSinir == 3)
            {
                _speedUpButton.SetActive(false);
                _isSpeedFinish = true;
                ShopSceneKapat();
            }
        }
        
    }

    public void Yavaslat()
    {
        if (_yavaslatSinir < 3 && _basket.point >= 50)
        {
            _basket.point -= 50;
            _basket.PointTextUpdate(_basket.point);
            _newValue._newBornValue -= 0.3f;
            _newValue1._newBornValue -= 0.3f;
            _yavaslatSinir++;
            if (_yavaslatSinir == 3)
            {
                _yavaslatmaButton.SetActive(false);
                _isYavaslatFinish = true;
                ShopSceneKapat();
            }
        }
        
    }

    public void Genislet()
    {
        if (_genisletSinir < 3 && _basket.point >= 50)
        {
            _basket.point -= 50;
            _basket.PointTextUpdate(_basket.point);
            _basket._scaleX += 0.015f;
            _basket._scaleY += 0.015f;
            _genisletSinir++;
            if (_genisletSinir == 3)
            {
                _ExpansionButton.SetActive(false);
                _isGenisletFinish = true;
                ShopSceneKapat();
            }
        }
        
    }

    void ShopSceneKapat()
    {
        if (_isGenisletFinish && _isYavaslatFinish && _isSpeedFinish)
        {
            _shop.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
