using System;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour {

    //behavior to be executed upon impact with the power-up
    protected Action<GameObject> effect;
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        effect.Invoke(collision.collider.gameObject);
    }

}
