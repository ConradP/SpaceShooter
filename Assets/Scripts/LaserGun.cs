using System;
using UnityEngine;

public class LaserGun : Weapon {

    public Laser1 laserPrefab;
    private readonly double  cooldown = 250;
    public LaserGun()
    {
        cycleTimer = new System.Timers.Timer(cooldown);
        cycleTimer.AutoReset = true;
        cycleTimer.Elapsed += CycleTimer_Elapsed;
        readyToFire = true;
    }

    private void CycleTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        cycleTimer.Stop();
        readyToFire = true;
    }

 
    public override void Fire()
    {
        if (readyToFire)
        {
            readyToFire = false;
            var bullet = Instantiate(laserPrefab, transform.localPosition, Quaternion.identity);
            cycleTimer.Start();
        }
    }
}
