using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    //public Godot.Vector2 Velocity;
    public int Gravity;
    public Godot.Vector2 NewVelocity;
    public override void _Ready()
    {
        Velocity = Godot.Vector2.Zero;
        Gravity = 100;
        NewVelocity = Velocity;

    }

    public override void _PhysicsProcess(double delta)
    {
        NewVelocity.Y += Gravity;
        Velocity = NewVelocity;
        // player_controls(delta);
        GD.Print(Velocity);

    }

    // public void player_controls(double delta)
    // {
    //     if (Input.IsActionPressed("Jetpack")){
    //         Velocity.Y = Velocity.Y + 100 * (float)delta;
    //     }
    // }



}
