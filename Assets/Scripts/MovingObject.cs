using System;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class MovingObject :MonoBehaviour
    {
        public float speed;
        protected float verticalBounds = GameController.verticalBounds;
        protected float horizontalBounds = GameController.horizontalBounds;
        public virtual void Start() { }
        public virtual void Update() {
            BoundsCheck();
        }

        protected void BoundsCheck()
        {
            var pos = transform.localPosition;
            if (Math.Abs(pos.x) > horizontalBounds || Math.Abs(pos.y) > verticalBounds)
            {
                Destroy(gameObject);
            }
        }
    }
}
