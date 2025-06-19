using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	// Loads coin scene in a variable to be instatiated later.
	public PackedScene CoinScene = GD.Load<PackedScene>("res://src/coin/coin.tscn");
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		// Instatiate coin scene.
		StaticBody2D coinInstance = (StaticBody2D)CoinScene.Instantiate();
		coinInstance.Name = "Coin";
		AddChild(coinInstance);
		// Change posiiton of Coin after instantiating.
		GetNode<StaticBody2D>("Coin").Position = new Vector2(321, 343);
	}

	// Not being used yet.
	public override void _Process(double delta)
	{
	}
}
