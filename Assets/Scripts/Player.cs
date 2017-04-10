using UnityEngine;

/// <summary>
/// handles input directed to the ship
/// </summary>
public class Player : MonoBehaviour
{


    public Ship ship;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ship == null)
            return;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetButton("Fire1"))
        {
            ship.Shoot();
        }
    }
}
