using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    public int Gravity;
    public Godot.Vector2 NewVelocity;
    public bool TouchingFloor;

    public override void _Ready()
    {
        Velocity = Godot.Vector2.Zero;
        Gravity = 200;
        // Speed = 200;
        NewVelocity = Velocity;
        GetNode<Area2D>("Area2D").BodyEntered += OnBodyEntered;
        TouchingFloor = false;
    }

    public override void _PhysicsProcess(double delta)
    {
        if (!TouchingFloor)
        {
            NewVelocity.Y += Gravity * (float)delta;
        }
        else
        {
            NewVelocity.Y = 0;
        }
        // NewVelocity.X += Speed * (float)delta;
        PlayerJetpack(delta);
        Velocity = NewVelocity;
        MoveAndSlide();
    }

    public void PlayerJetpack(double delta)
    {
        if (Input.IsActionPressed("Jetpack"))
        {
            NewVelocity.Y -= 500 * (float)delta;
            TouchingFloor = false;
        }
    }

    public void OnBodyEntered(Node2D body) {
        GD.Print("Works");

        if (body is StaticBody2D)
        {
            TouchingFloor = true;
            GD.Print("Works");
        }
    }

}
