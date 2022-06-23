using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje1.Cores 
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;

        static bool _isFirsttime = true;
        private void Start()
        {
            if (_isFirsttime)
            {
                SpawnPersistentObjects();
                _isFirsttime = false;
            }
        }

        private void SpawnPersistentObjects()
        {
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}

