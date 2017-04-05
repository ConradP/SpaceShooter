using Assets.Scripts;
using UnityEngine;

/// <summary>
/// api for handling inputs from the player class
/// </summary>
public class Ship : MovingObject {

    [SerializeField]
    private int health;
    [SerializeField]
    private Weapon weapon;
   
    float screenWidth, screenHeight;
    public int Health { get { return health; } }
    // Use this for initialization
    public override void  Start () {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    public void Move(float deltaX, float deltaY)
    {
       
        deltaX *= speed;
        deltaY *= speed;
      
        transform.Translate(deltaX, deltaY, 0);
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
