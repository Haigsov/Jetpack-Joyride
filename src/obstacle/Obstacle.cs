using Godot;
using System;

public partial class Obstacle : Area2D
{
	// CollisionShape2D Variable.
	RectangleShape2D shape;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		shape = GetNode<CollisionShape2D>("CollisionShape2D").Shape as RectangleShape2D;
		GD.Print("Before: ", shape.Size);

		// Change CollisionShape2D's size.
		shape.Size = new Vector2(400, 100);
		GD.Print("After: ", shape.Size);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
