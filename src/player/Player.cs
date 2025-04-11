using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    public int speed = 200;

    // Wrote some code that don't work
    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        Velocity = new Godot.Vector2(0, 0);
    }
    public override void _PhysicsProcess(double delta)
    {
    }


}
