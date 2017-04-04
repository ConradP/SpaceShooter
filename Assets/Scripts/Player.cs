using UnityEngine;

/// <summary>
/// handles input directed to the ship
/// </summary>
public class Player : MonoBehaviour
{

    [SerializeField]
    private Ship ship;
    
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0 || y != 0)
        {
            ship.Move(Input.GetAxis("Horizontal")/2, Input.GetAxis("Vertical")/2);
        }
        
        if (Input.GetButton("Fire1"))
        {
            ship.Shoot();
        }
    }
}
