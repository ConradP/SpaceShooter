using System;
using UnityEngine;

public class Hull : MonoBehaviour {
    public int health;
    public DamageReceiver damageReceiver;
    public SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
        damageReceiver.onDamageReceived += damage_applied;
	}

    private void damage_applied(int damage)
    {
        health -= damage;
    }

    public bool hasHealth()
    {
        return health > 0;
    }
}
