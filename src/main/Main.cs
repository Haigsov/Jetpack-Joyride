using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	// Loads coin scene in a variable to be instatiated later.
	public PackedScene CoinScene = GD.Load<PackedScene>("res://src/coin/coin.tscn");
	public StaticBody2D Floor;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Floor = GetNode<StaticBody2D>("Floor");
		GD.Print(Floor);
		// Instatiate coin scene.
		CharacterBody2D coinInstance = (CharacterBody2D)CoinScene.Instantiate();
		coinInstance.Name = "Coin";
		AddChild(coinInstance);
		// Change posiiton of Coin after instantiating.
		GetNode<CharacterBody2D>("Coin").Position = new Vector2(321, 343);
		// Set up coin velocity.
		GetNode<CharacterBody2D>("Coin").Velocity = Vector2.Zero;

	}

	// Moves coins for now.
	public override void _Process(double delta)
	{
		GetNode<CharacterBody2D>("Coin").Velocity = new Vector2(-20, 0);
		GetNode<CharacterBody2D>("Coin").MoveAndSlide();
	}
}
