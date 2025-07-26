using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	// Loads packed scenes.
	private PackedScene CoinScene = GD.Load<PackedScene>("res://src/coin/coin.tscn");
	private PackedScene ObstacleScene = GD.Load<PackedScene>("res://src/obstacle/obstacle.tscn");

	private Coin coinInstance;
	private Obstacle obstacleInstance;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Instantiate the obstacle
		obstacleInstance = (Obstacle)ObstacleScene.Instantiate();
		obstacleInstance.Name = "Obstacle";
		AddChild(obstacleInstance);

		// Instantiate coin scene.
		for (int i = 0; i < 3; i++)
		{
			coinInstance = (Coin)CoinScene.Instantiate();
			coinInstance.Name = $"Coin{i}";

			// Change posiiton of Coin after instantiating.
			coinInstance.Position = new Vector2(621 + (i * 100), 343);
			AddChild(coinInstance);
		}

		GetNode<Obstacle>("Obstacle").Position = new Vector2(GetNode<Obstacle>("Obstacle").Position.X + 800, 200);
	}
}
