namespace Assets.Scripts
{
    class ShieldOverload : PowerUp
    {
        public double duration;
        public void Start()
        {
            effect = (ship) =>
            {

                var shield = ship.GetComponentInChildren<Shield>();
                shield.overCharge(duration);
                Destroy(gameObject);
            };
        }
    }
}
