using Assets.Scripts;
using UnityEngine;

/// <summary>
/// api for handling inputs from the player class
/// </summary>
public class Ship : MovingObject
{
    public Weapon weapon;
    public DamageReceiver damageReceiver;
    public Engine engine;
    public Shield shield;
    public Hull hull;
    public Rigidbody2D rb;

    float screenWidth, screenHeight;
    // Use this for initialization
    public override void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        rb = GetComponent<Rigidbody2D>();
        damageReceiver.onDamageReceived += HandleDamageReceived;
    }

    /// <summary>
    /// ship distributes total damage received point by point, first to the shields then the hull.
    /// </summary>
    /// <param name="amount"></param>
    private void HandleDamageReceived(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (shield.hasCharges())
            {
                shield.charges -= 1;
            }
            else if (hull.hasHealth())
            {
                hull.health -= 1;
            }
            else
            {
                Destroy(gameObject);
                break;
            }
        }
    }

    public void Move(float deltaX, float deltaY)
    {

        deltaX *= engine.thrust;
        deltaY *= engine.thrust;
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
}
