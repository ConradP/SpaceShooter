using Assets.Scripts;

public class Asteroid : MovingObject {

    public int Health { get; set; }


    public override void Start()
    {
        speed = GameController.scrollspeed;
    }

    public override void Update()
    {
        transform.position -= transform.up*speed;
        base.Update();
    }




}
