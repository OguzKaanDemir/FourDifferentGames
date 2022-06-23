using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject _gold;
    public GameObject _shopButton;
    public GameObject _diePanel;
    public GameObject _movePanel;
    public GameObject _heart1;
    public GameObject _heart2;
    public GameObject _heart3;
    [SerializeField] Basket _basket;
    private int _sayac = 0;
   
    void Update()
    {
        FinishGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hotdog" || collision.gameObject.tag == "Hamburger")
        {
            _sayac++;
            
            if (_sayac == 1)
            {
                _heart3.SetActive(false);
            }
            if (_sayac == 2)
            {
                _heart2.SetActive(false);
            }
            if (_sayac == 3)
            {
                _heart1.SetActive(false);
                _shopButton.SetActive(false);
                _gold.SetActive(false);
                Time.timeScale = 0;
                _diePanel.SetActive(true);
            }
        }
    }

    public void FinishGame()
    {
        _sayac += _basket._canAzalt;
        if (_sayac == 1)
        {

            _heart3.SetActive(false);
        }
        if (_sayac == 2)
        {
            _heart2.SetActive(false);
        }
        if (_sayac == 3)
        {
            _movePanel.SetActive(false);
            _gold.SetActive(false);
            _heart1.SetActive(false);
            _shopButton.SetActive(false);
            Time.timeScale = 0;
            _diePanel.SetActive(true);
        }
    }
}
