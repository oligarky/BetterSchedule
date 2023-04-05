using Godot;
using System;
using System.Collections.Generic;

public partial class filter_hiding : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Listing");
		var head = this.GetChild(0);
		var i = 0;
		List<Label> classes= new List<Label>();
		GD.Print(head.GetChild(i));
		while(head.GetChild(i)!=null){
			GD.Print(head.GetChild(i));
			GD.Print(head.GetChild(i).GetChild(0));
			classes.Add((Label)head.GetChild(i).GetChild(0));
			
			i+=1;
			GD.Print(i);
		}
		foreach (Label n in classes){
			GD.Print(n);
		}
		GD.Print("End list");

	}
	private void _on_pressed()
	{
		//This is what should be done when we replace labels with RichTextLabels
		GD.Print("Listing");
		var head = this.GetChild(0);
		var i = 0;
		List<RichTextLabel> classes= new List<RichTextLabel>();
		while(head.GetChild(i)!=null){
			classes.Add((RichTextLabel)head.GetChild(i).GetChild(0));
			i++;
		}
		foreach (RichTextLabel n in classes){
			GD.Print(n);
		}
		GD.Print("End list");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
