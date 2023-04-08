using Godot;
using System;

public partial class FilterHandler : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Whole code block should be moved to a button press for applying filters
		filter_hiding filter = new filter_hiding(); //importing method in C# for other scripts
		filter.listlabels(this.GetChild<VBoxContainer>(0));//This will need to be checked in final to make sure it is correct
		filter.filterby("COMP");//example used is COMP but will eventaully be finding the text from nodes elsewhere
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
