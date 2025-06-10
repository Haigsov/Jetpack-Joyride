using Godot;
using System;
using System.Numerics;

public partial class Player : CharacterBody2D
{
    //public Godot.Vector2 Velocity;
    public int Gravity;
    public override void _Ready()
    {
        Velocity = Godot.Vector2.Zero;
        Gravity = 10;
    }

    public override void _PhysicsProcess(double delta)
    {
        //Gravity making it go down
        Set("Velocity") -= 10 * (float)delta;
        player_controls(delta);
        GD.Print(Velocity);

    }

    public void player_controls(double delta)
    {
        if (Input.IsActionPressed("Jetpack")){
            Velocity.Y = Velocity.Y + 100 * (float)delta;
        }
    }



}
