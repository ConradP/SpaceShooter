using UnityEngine;

namespace Assets.Scripts
{
    public class KillEnemies : PowerUp
    {
        public void Start()
        {
            effect = (ship) =>
            {
                //TODO: animate
                //TODO: audio
                GameObject[] objs = GameObject.FindGameObjectsWithTag("enemy");
                foreach (var obj in objs)
                {
                    Destroy(obj);
                   
                }
                Destroy(gameObject);
            };
        }
    }
}
