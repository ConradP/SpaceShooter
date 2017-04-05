using UnityEngine;

public class LaserGun : Weapon
{

    public LaserBasic laserPrefab;
    public static float cooldown = 250;
    public LaserGun() : base(cooldown)
    {

    }

    protected override void Discharge()
    {
        Instantiate(laserPrefab, transform.position, transform.rotation);
    }
}

