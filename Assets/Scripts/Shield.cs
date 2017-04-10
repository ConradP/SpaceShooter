using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Shield : MonoBehaviour {

    public int charges;
    public int maxCharges;
    public float rechargeRate;
    private Timer rechargeTimer;
    public DamageReceiver damageReceiver;
	// Use this for initialization
	void Start () {
        rechargeTimer = new Timer(rechargeRate);
        rechargeTimer.AutoReset = true;
        rechargeTimer.Elapsed += RechargeTimer_Elapsed;
        damageReceiver.onDamageReceived += r => charges -= r;
        rechargeTimer.Start();
	}

    private void RechargeTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        rechargeTimer.Stop();
        if(charges < maxCharges) charges += 1;
        rechargeTimer.Start();
    }
}
