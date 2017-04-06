using System;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public Action<int> onDamageReceived;

    public void ApplyDamage(int amount)
    {
        if ( onDamageReceived != null )
        {
            onDamageReceived(amount);
        }
    }
}