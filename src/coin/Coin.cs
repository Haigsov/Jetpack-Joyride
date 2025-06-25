using Godot;
using System;

public partial class Coin : Area2D
{

	public Vector2 velocity;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		velocity = Vector2.Zero;
		BodyEntered += OnBodyEntered;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Moves coin 2 pixels per frame left.
		velocity = new Vector2(-20, 0);
		Position += velocity * (float)delta;
	}

	public void OnBodyEntered(Node2D _body)
	{
		QueueFree();
	}
}
