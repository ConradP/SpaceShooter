using Assets.Scripts;
using UnityEngine;

public abstract class Projectile : MovingObject {

    public Rigidbody2D rb;
    public int damage;
    public float speed;
    public override void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (transform.up * speed);
    }

    public override void Update()
    {
        //transform.localPosition += transform.up * speed;

        base.Update();

        //rb.AddForce(transform.up * speed);
        //rb.velocity = (transform.up * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //pass damage value to damage receiver
        DamageReceiver receiver = collision.collider.GetComponent<DamageReceiver>();
        if ( receiver != null )
        {
            receiver.ApplyDamage(damage);
            Destroy(gameObject);
        }
    }
}
