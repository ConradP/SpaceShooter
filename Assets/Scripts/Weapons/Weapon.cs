using System.Timers;
using UnityEngine;

/// <summary>
/// superclass for weapon classes that handles fire cycling
/// </summary> 
public abstract class Weapon : MonoBehaviour
{
    protected Timer cycleTimer;
    protected bool readyToFire;
    protected abstract void Discharge();

    /// <summary>
    /// base constructor used to setup the timer used for handling cycling the weapon
    /// </summary>
    /// <param name="coolDown"></param>
    public Weapon(float coolDown)
    {
        cycleTimer = new Timer(coolDown);
        cycleTimer.AutoReset = true;
        cycleTimer.Elapsed += CycleTimer_Elapsed;
        readyToFire = true;
    }
    /// <summary>
    /// handles initiating the weapons firing cycle
    /// </summary>
    public virtual void Fire()
    {
        if (readyToFire)
        {
            Discharge();
            readyToFire = false;
            cycleTimer.Start();
        }
    }

    /// <summary>
    /// changes the weapon back to a ready state once the cycleTimer has elapsed
    /// </summary>
    protected virtual void CycleTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        cycleTimer.Stop();
        readyToFire = true;
    }
}