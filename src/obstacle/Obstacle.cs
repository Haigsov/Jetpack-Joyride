using Godot;
using System;

public partial class Obstacle : Area2D
{
	// CollisionShape2D Variable.
	private RectangleShape2D _shape;
	private Polygon2D poly;
	public Vector2 velocity;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;

		_shape = GetNode<CollisionShape2D>("CollisionShape2D").Shape as RectangleShape2D;
		GD.Print("Before: ", _shape.Size);

		// Change CollisionShape2D's size.
		_shape.Size = new Vector2(GD.RandRange(100, 450), 20);
		GD.Print("After: ", _shape.Size);

		// Change Polygon2D size.
		poly = GetNode<Polygon2D>("Polygon2D");
		Vector2 halfSize = _shape.Size / 2;

		poly.Polygon = new Vector2[]
		{
			new Vector2(-halfSize.X,-halfSize.Y),
			new Vector2(halfSize.X,-halfSize.Y),
			new Vector2(halfSize.X,halfSize.Y),
			new Vector2(-halfSize.X,halfSize.Y)
		};

		// Change Rotation.
		Rotation = GD.RandRange(0, 360);

		Position = new Vector2(GD.RandRange(100, 200), GD.RandRange(100, 200));

		velocity = new Vector2(-80, 0);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += velocity * (float)delta;
	}

	public void OnBodyEntered(Node2D body)
	{
		body.QueueFree();
	}
}
