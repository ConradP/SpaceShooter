using System;
using UnityEngine;

public abstract class Projectile : MonoBehaviour {
  
    protected float speed;

    protected readonly float Bounds = 10.0f;
    
    public abstract void Start();

     public virtual void Update()
    {
        transform.position += transform.up * speed;
        BoundsCheck();
    }

    private void BoundsCheck()
    {
        var pos = transform.localPosition;
       if (Math.Abs(pos.x)>Bounds || Math.Abs(pos.y) > Bounds)
        {
            Destroy(gameObject);
        }
    }
}
