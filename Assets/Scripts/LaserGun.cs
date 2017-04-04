using UnityEngine;

public class LaserGun : Weapon {

    public Laser1 laserPrefab;


    public override void Fire()
    {
        var bullet = Instantiate(laserPrefab, transform.localPosition, Quaternion.identity);
    }
}
