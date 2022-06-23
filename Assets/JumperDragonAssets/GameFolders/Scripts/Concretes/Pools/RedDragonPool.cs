using System.Collections;
using UdemyProje1.Abstracts.Pools;
using UdemyProje1.Controllers;
using UnityEngine;

namespace UdemyProje1.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set;}

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
            {
                if (!child.gameObject.activeSelf)
                {
                    continue;
                }
                else
                {
                    child.KillGameObject();
                }
            }
        }

        protected override void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this);
            }
        }

        
    }
}
