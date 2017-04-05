using System;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class MovingObject :MonoBehaviour
    {
        public float speed;
        protected float Bounds = GameController.Bounds;
        public virtual void Start() { }
        public virtual void Update() {
            BoundsCheck();
        }

        protected void BoundsCheck()
        {
            var pos = transform.localPosition;
            if (Math.Abs(pos.x) > Bounds || Math.Abs(pos.y) > Bounds)
            {
                Destroy(gameObject);
            }
        }
    }
}
