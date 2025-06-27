using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	// Loads coin scene in a variable to be instatiated later.
	public PackedScene CoinScene = GD.Load<PackedScene>("res://src/coin/coin.tscn");
	Coin coinInstance;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Floor = GetNode<StaticBody2D>("Floor");
		// Instatiate coin scene.
		for (int i = 0; i < 3; i++)
		{
			coinInstance = (Coin)CoinScene.Instantiate();
			coinInstance.Name = $"Coin{i}";
			// Change posiiton of Coin after instantiating.
			//GetNode<Coin>($"Coin{i}")
			coinInstance.Position = new Vector2(621 + (i * 100), 343);
			AddChild(coinInstance);
		}



	}

	public override void _Process(double delta)
	{
	}
}
