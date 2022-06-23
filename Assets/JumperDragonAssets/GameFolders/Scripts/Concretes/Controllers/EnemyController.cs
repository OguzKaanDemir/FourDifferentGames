using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Abstracts.Controllers;
using UdemyProje1.Pools;
using UnityEngine;

namespace UdemyProje1.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {

        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();

    }

}