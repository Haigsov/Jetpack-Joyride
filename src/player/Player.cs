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
        velocity += GetGravity() * (float)delta;
        GD.Print(velocity);

    }

    public void player_controls()
    {
        Input.IsActionPressed("Jetpack");
    }



}
