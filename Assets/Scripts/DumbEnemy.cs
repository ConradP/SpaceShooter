using UnityEngine;

public class DumbEnemy : MonoBehaviour
{
    public Ship ship;
    public bool directionToggle;

    // Update is called once per frame
    void Update()
    {
        if (ship == null)
            return;


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
        if (ship.transform.position.x >= 8f)
        {
            directionToggle = !directionToggle;
        }
        if (ship.transform.position.x <= -8f)
        {
            directionToggle = !directionToggle;
        }
    }
}
