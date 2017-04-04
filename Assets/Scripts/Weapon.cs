using System.Timers;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    public abstract void Fire();
    protected Timer cycleTimer;
    protected bool readyToFire;
}