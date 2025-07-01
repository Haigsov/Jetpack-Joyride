using Godot;
using System;

public partial class Rocket : Area2D
{

	Vector2 velocity;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		velocity = Vector2.Zero;
		BodyEntered += OnBodyEntered;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		velocity = new Vector2(-40, 0);
		Position += velocity * (float)delta;
	}

	public void OnBodyEntered(Node2D body)
	{
		body.QueueFree();
	}
}
