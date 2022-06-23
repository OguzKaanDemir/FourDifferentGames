using System.Collections;
using System.Collections.Generic;
using UdemyProje1.Abstracts.Spawners;
using UdemyProje1.Controllers;
using UdemyProje1.Movements;
using UdemyProje1.Pools;
using UnityEngine;

namespace UdemyProje1.Spawners
{
    public class ObstcileSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController poolEnemy = ObsticlePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }
}
