using System.Timers;
using UnityEngine;

public class Shield : MonoBehaviour {

    public int charges;
    public bool overChargeState = false;
    public int maxCharges;
    public float rechargeRate;
    private Timer rechargeTimer;
    private Timer overChargeTimer;
    public DamageReceiver damageReceiver;
	// Use this for initialization
	void Start () {
        rechargeTimer = new Timer(rechargeRate);
        rechargeTimer.AutoReset = true;
        rechargeTimer.Elapsed += RechargeTimer_Elapsed;
        damageReceiver.onDamageReceived += onDamage_Handler;
        rechargeTimer.Start();
	}

    private void onDamage_Handler(int damage)
    {
         if (!overChargeState) charges -= damage;
    }

    private void RechargeTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        rechargeTimer.Stop();
        if(charges < maxCharges) charges += 1;
        rechargeTimer.Start();
    }

    public bool hasCharges()
    {
        return charges > 0;
    }

    public void overCharge(double duration)
    {
        overChargeState = true;
        //TODO: overcharge sound and animation
        overChargeTimer = new Timer(duration);
        overChargeTimer.Elapsed += overChargeTimer_Elapsed;
        overChargeTimer.Start();
    }

    private void overChargeTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        overChargeTimer.Stop();
        overChargeState = false;
        overChargeTimer.Dispose();
        //TODO: disable overcharge sound and animation
    }
}
