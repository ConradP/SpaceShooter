using UnityEngine;

public class BulletGun : Weapon
{
    public static float cooldown = 500;
    public BulletBasic bulletPreFab;
    public BulletGun() : base(cooldown)
    {
    }



    protected override void Discharge()
    {
        Instantiate(bulletPreFab, transform.position, transform.rotation);
    }
}
