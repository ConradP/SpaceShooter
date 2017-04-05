using Assets.Scripts;

public abstract class Projectile : MovingObject {

     public override void Update()
    {
        transform.localPosition += transform.up * speed;
        base.Update();
    }
}
