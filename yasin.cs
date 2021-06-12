using Godot;
using System;

public class yasin : KinematicBody2D
{
    // Declare member variables here. Examples:
    private Vector2 _velocity = new Vector2();
    const int SPEEED = 180;
    const int GRAVITY =35;
    const int JUMPFORCE = -1100;


    public override void _PhysicsProcess(float _delta)
    {
       if (Input.IsActionPressed("right")){
           _velocity.x = SPEEED;
       }

       if (Input.IsActionPressed("left")){
           _velocity.x = -SPEEED;
       }

       if (Input.IsActionJustPressed("jump")){
           _velocity.y = JUMPFORCE;
       }

       _velocity = MoveAndCollide(_velocity);


        _velocity.x = Mathf.Lerp(_velocity.x, 0, 2);
            
    }
}
