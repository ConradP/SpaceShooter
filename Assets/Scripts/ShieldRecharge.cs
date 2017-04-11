namespace Assets.Scripts
{
    class ShieldRecharge:PowerUp
    {
     
        public void Start()
        {
            effect = (ship) =>
            {
                var shield = ship.GetComponentInChildren<Shield>();
                shield.charges = shield.maxCharges;
                Destroy(gameObject);
            };
        }
    }
}
