using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [Header("BOMB")]
    public GameObject _bombPrefab;

    GameObject _bombGameObject;
    Vector3 _bombPosition;
    float x;
    float _instantiateTime = 0f;
    int _instantiateCount = 0;
    float newLimit;
    public float _newBornValue = 0;


    void Start()
    {
        
    }

    void Update()
    {
        Instante();
    }

    #region Hamburger Methods

    public void HambuergerInstantiate()
    {
        _instantiateCount++;
        x = Random.Range(-8f, 8.3f);
        _bombPosition = new Vector3(x, 10, 0);
        _bombGameObject = Instantiate(_bombPrefab, _bombPosition, Quaternion.identity);
    }

    #endregion

    public void Instante()
    {
        if (_instantiateCount <= 10)
        {
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > 5.5f)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount > 10)
        {
            newLimit = 5.2f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount >= 20)
        {
            newLimit = 5f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
    }
}
