using Godot;
using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Main : Node2D
{
	[Export]
	public PackedScene CoinScene { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		Node coinInstance = CoinScene.Instantiate();

		AddChild(coinInstance);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
