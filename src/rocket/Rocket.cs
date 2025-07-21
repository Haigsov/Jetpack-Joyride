using Godot;
using System;

public partial class Rocket : GameElement
{
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		velocity = new Vector2(-40, 0);
		Position += velocity * (float)delta;
	}

	public override void OnBodyEntered(Node2D body)
	{
		body.QueueFree();
	}
}
