using System;
using Assets.Scripts;
using UnityEngine;

public class DumbEnemy : MonoBehaviour
{
    public Ship ship;
    public bool directionToggle;

    // Update is called once per frame
     void Update()
    {
        if (directionToggle)
        {
            ship.Move(1.0f, 0f);
            checkDirection();

        }
        else
        {
            ship.Move(-1.0f, 0f);
            checkDirection();
        }
        ship.Shoot();
    }

    private void checkDirection()
    {
        if (ship.transform.localPosition.x >= 8f)
        {
            directionToggle = !directionToggle;
        }
        if(ship.transform.localPosition.x <= -8f)
        {
            directionToggle = !directionToggle;
        }
    }
}
