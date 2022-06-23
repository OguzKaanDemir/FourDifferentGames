using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Controllers;
using UnityEngine;

namespace UdemyProje1.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform procetileTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 0.7f;

        float _currentDelayTime = 0;
        bool _canLaunch = false;


        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
                ProjectileController newProjectile =  Instantiate(projectilePrefab, procetileTransform.position, procetileTransform.transform.rotation);
                newProjectile.transform.parent = projectileParent.transform;
               _canLaunch = false;
            }
             
        }
    }
}
