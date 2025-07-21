using Godot;
using System;

public abstract partial class GameElement : Area2D
{
	public Vector2 velocity;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		velocity = Vector2.Zero;
		BodyEntered += OnBodyEntered;
	}

	public virtual void OnBodyEntered(Node2D _body)
	{
		QueueFree();
	}
}
