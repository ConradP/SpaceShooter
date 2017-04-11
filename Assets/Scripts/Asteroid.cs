using Assets.Scripts;

public class Asteroid : MovingObject {

    public int Health { get; set; }

    public override void Update()
    {
        transform.position -= transform.up* GameController.scrollspeed;
        base.Update();
    }




}
