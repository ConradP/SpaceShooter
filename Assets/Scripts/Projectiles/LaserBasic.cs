public class LaserBasic: Projectile
{
   public override void Start()
    {
        base.Start();
        damage = 2; 
        speed = 0.25f;
    }
}