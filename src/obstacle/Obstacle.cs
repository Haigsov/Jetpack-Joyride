using Godot;
using System;

public partial class Obstacle : Area2D
{
	// CollisionShape2D Variable.
	private RectangleShape2D _shape;
	private Polygon2D poly;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_shape = GetNode<CollisionShape2D>("CollisionShape2D").Shape as RectangleShape2D;
		GD.Print("Before: ", _shape.Size);

		// Change CollisionShape2D's size.
		_shape.Size = new Vector2(GD.RandRange(100, 1000), 20);
		GD.Print("After: ", _shape.Size);

		poly = GetNode<Polygon2D>("Polygon2D");
		Vector2 halfSize = _shape.Size / 2;

		poly.Polygon = new Vector2[]
		{
			new Vector2(-halfSize.X,-halfSize.Y),
			new Vector2(halfSize.X,-halfSize.Y),
			new Vector2(halfSize.X,halfSize.Y),
			new Vector2(-halfSize.X,halfSize.Y)
		};

		Rotation = GD.RandRange(0, 360);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
