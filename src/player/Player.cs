using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    public int gravity = 200;
    public Godot.Vector2 velocity = Godot.Vector2.Zero;
    // Wrote some code that don't work
    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        GD.Print(velocity);
        //Set("Position", Godot.Vector2(343,343));
        //GD.Print(Get("Position.Y"));
    }

    public override void _PhysicsProcess(double delta)
    {

		velocity += GetGravity() * (float)delta;

    }



}
