using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    //public Godot.Vector2 Velocity;
    public int Gravity;
    public Godot.Vector2 NewVelocity;
    public int Speed;

    public override void _Ready()
    {
        Velocity = Godot.Vector2.Zero;
        Gravity = 200;
        Speed = 200;
        NewVelocity = Velocity;
    }

    public override void _PhysicsProcess(double delta)
    {
        NewVelocity.Y += Gravity * (float)delta;
        NewVelocity.X += Speed * (float)delta;
        Velocity = NewVelocity;
        MoveAndSlide();
        GD.Print(Velocity);
    }

    // public void player_controls(double delta)
    // {
    //     if (Input.IsActionPressed("Jetpack")){
    //         Velocity.Y = Velocity.Y + 100 * (float)delta;
    //     }
    // }



}
