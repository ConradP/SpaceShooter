using UnityEngine;

/// <summary>
/// api for handling inputs from the player class
/// </summary>
public class Ship : MonoBehaviour {

    [SerializeField]
    private int health;
    [SerializeField]
    private Laser1 weapon;

    float screenWidth, screenHeight;
    public int Health { get { return health; } }   
	// Use this for initialization
	void Start () {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(float deltaX, float deltaY)
    {
        transform.Translate(deltaX, deltaY, 0);
        var newLocation = Camera.main.WorldToScreenPoint(transform.position);
        newLocation.x = Mathf.Clamp(newLocation.x, 0, screenWidth);
        newLocation.y = Mathf.Clamp(newLocation.y, 0, screenHeight);
        transform.position = Camera.main.ScreenToWorldPoint(newLocation);       
    }

    public void Shoot()
    {
        var bullet = Instantiate(weapon, transform.localPosition,Quaternion.identity);
    }

    //other fancy things
    public void ModifyHealth(int amount)
    {
        health += amount;
    }
}
