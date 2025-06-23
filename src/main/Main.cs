using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	// Loads coin scene in a variable to be instatiated later.
	public PackedScene CoinScene = GD.Load<PackedScene>("res://src/coin/coin.tscn");
	// public StaticBody2D Floor;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Floor = GetNode<StaticBody2D>("Floor");
		// Instatiate coin scene.
		Coin coinInstance = (Coin)CoinScene.Instantiate();
		coinInstance.Name = "Coin";
		AddChild(coinInstance);

		// Change posiiton of Coin after instantiating.
		GetNode<Coin>("Coin").Position = new Vector2(321, 343);

		// Set up coin velocity.
		GetNode<Coin>("Coin").velocity = Vector2.Zero;
	}

	// Moves coins for now.
	public override void _Process(double delta)
	{
		GetNode<Coin>("Coin").velocity = new Vector2(-20, 0);
		GetNode<Coin>("Coin").Position += GetNode<Coin>("Coin").velocity * (float)delta;
	}
}
