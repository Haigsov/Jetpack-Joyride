using Godot;
using System;

public partial class Coin : GameElement
{
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Moves coin 2 pixels per frame left.
		velocity = new Vector2(-100, 0);
		Position += velocity * (float)delta;
	}
}
