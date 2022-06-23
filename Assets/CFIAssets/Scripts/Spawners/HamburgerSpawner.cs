using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamburgerSpawner : MonoBehaviour
{
    [Header("HAMBURGER")]
    public GameObject _hambugerPrefab;

    GameObject _hamburgerGameObject;
    Vector3 _hamburgerPosition;
    float x;
    float _instantiateTime = 0f;
    public float _newBornValue = 0;

    int _instantiateCount = 0;
    float newLimit;

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
        _hamburgerPosition = new Vector3(x, 10, 0);
        _hamburgerGameObject = Instantiate(_hambugerPrefab, _hamburgerPosition, Quaternion.identity);
    }

    #endregion

    public void Instante()
    {
        if (_instantiateCount <= 20)
        {
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > 1.7f)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount > 20)
        {
            newLimit = 1.5f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount > 40)
        {
            newLimit = 1.4f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
    }
}
