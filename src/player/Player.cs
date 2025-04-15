using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    public int speed = 200;
    public Godot.Vector2 vel = Godot.Vector2.Zero;
    // Wrote some code that don't work
    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        var velocity = Godot.Vector2.Zero;
        GD.Print(velocity);
        GD.Print(vel);
    }


}
