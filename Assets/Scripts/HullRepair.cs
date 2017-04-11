namespace Assets.Scripts
{
    class HullRepair:PowerUp
    {
        public void Start()
        {
            effect = (ship) =>
            {
                var hull = ship.GetComponentInChildren<Hull>();
                hull.health = hull.maxHealth;
                Destroy(gameObject);
            };
        }
    }
}
