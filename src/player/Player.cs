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
        NewVelocity = Velocity;
        TouchingFloor = false;

        // Connect signal to a signal handler.
        GetNode<Area2D>("Area2D").BodyEntered += OnBodyEntered;
    }

    public override void _PhysicsProcess(double delta)
    {
        /* When player is on the floor, we set the vertical velocity as 0.
        If we leave it as is the gravity will keep appending on the Velocity.y and
        slow down the Jetpack when lifting off the ground.*/
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
        // Check if player is hitting Jetpack (Space)
        if (Input.IsActionPressed("Jetpack"))
        {
            NewVelocity.Y -= 500 * (float)delta;
            TouchingFloor = false;
        }
    }

    public void OnBodyEntered(Node2D body)
    {
        // Checks if player is on the floor.
        if (body is StaticBody2D)
        {
            TouchingFloor = true;
        }

        else if (body is Coin)
        {
            body.QueueFree();
        }
    }

}
