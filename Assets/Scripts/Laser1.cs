using UnityEngine;
public class Laser1: Projectile
{
    void Start()
    {

    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f);
        if (transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }
    }
}