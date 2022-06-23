using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogSpawner : MonoBehaviour
{
    [Header("HOTDOG")]
    public GameObject _hotdogPrefab;

    GameObject _hotdogGameObject;
    Vector3 _hotdogPosition;
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
        Ýnstante();
    }

    #region Hamburger Methods

    public void HambuergerInstantiate()
    {
        _instantiateCount++;
        x = Random.Range(-8f, 8.3f);
        _hotdogPosition = new Vector3(x, 10, 0);
        _hotdogGameObject = Instantiate(_hotdogPrefab, _hotdogPosition, Quaternion.identity);
    }

    #endregion

    public void Ýnstante()
    {
        if (_instantiateCount <= 15)
        {
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > 2.8f)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount > 15)
        {
            newLimit = 2.6f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
        if (_instantiateCount > 30)
        {
            newLimit = 2.4f;
            _instantiateTime += Time.deltaTime;
            if (_instantiateTime > newLimit)
            {
                HambuergerInstantiate();
                _instantiateTime = _newBornValue;
            }
        }
    }
}
