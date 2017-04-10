using Assets.Scripts;
using UnityEngine;

/// <summary>
/// api for handling inputs from the player class
/// </summary>
public class Ship : MovingObject
{


    public int health;
    public Weapon weapon;
    public DamageReceiver damageReceiver;
    public Engine engine;
    public Shield shield;
    private Rigidbody2D rb;

    float screenWidth, screenHeight;
    public int Health { get { return health; } }
    // Use this for initialization
    public override void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        rb = GetComponent<Rigidbody2D>();
        damageReceiver.onDamageReceived += HandleDamageReceived;
    }

    private void HandleDamageReceived(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Move(float deltaX, float deltaY)
    {

        deltaX *= speed;
        deltaY *= speed;
        rb.velocity = new Vector3(deltaX, deltaY, 0);
        // transform.Translate(deltaX, deltaY, 0);
        var newLocation = Camera.main.WorldToScreenPoint(transform.position);
        newLocation.x = Mathf.Clamp(newLocation.x, 0, screenWidth);
        newLocation.y = Mathf.Clamp(newLocation.y, 0, screenHeight);
        transform.position = Camera.main.ScreenToWorldPoint(newLocation);
    }

    public void Shoot()
    {
        weapon.Fire();
    }

    //other fancy things
    public void ModifyHealth(int amount)
    {
        health += amount;
    }

}
