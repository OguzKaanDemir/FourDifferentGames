using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Pools;
using UnityEngine;

namespace UdemyProje1.Controllers
{
    public class ObsticleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);
        }
    }

}
