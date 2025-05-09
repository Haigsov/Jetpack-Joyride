using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    public Godot.Vector2 velocity = Godot.Vector2.Zero;
    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        GD.Print(velocity);
        GD.Print(GetGravity());
    }

    public override void _PhysicsProcess(double delta)
    {
        //Gravity making it go down
        velocity.Y -= 10 * (float)delta;
        player_controls(delta);
        GD.Print(velocity);

    }

    public void player_controls(double delta)
    {
        if (Input.IsActionPressed("Jetpack")){
            velocity.Y = velocity.Y + 100 * (float)delta;
        }
    }



}
