using Godot;
using System;

public class HelloWorld : Node
{
	// Member variables here, example:
	private int a = 2;
	private string b = "textvar";

	public override void _Ready()
	{
		// Called every time the node is added to the scene.
		// Initialization here.
		GD.Print("Hello from C# to Godot :)");
	}

	public override void _Process(float delta)
	{
		// Called every frame. Delta is time since the last frame.
		// Update game logic here.
	}
}
