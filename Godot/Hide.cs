using Godot;
using System;

public partial class Hide : CheckButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
			
	}
	private void _on_pressed(){
		if(this.ButtonPressed){
			
			
			var p=GetParent();
			if(p==null){
				GD.Print("Null");
			}else{
				GD.Print(p);
			}
			var gp = p.GetParent();
			
			if(gp==null){
				GD.Print("Null");
			}else{
				GD.Print(gp);
			}
			var target = this.GetParent().GetParent().GetParent().GetChild(0).GetChild(0).GetChild(0);
			if(target==null){
				GD.Print("Target null");
			}else{
				GD.Print(target);
				GD.Print(target.GetPath());
				HBoxContainer t = (HBoxContainer) target;
				t.Hide();
			}
			GD.Print(this);
		
			
			GD.Print("Hello");
		}else{
			var target = this.GetParent().GetParent().GetParent().GetChild(0).GetChild(0).GetChild(0);
			
			if(target==null){
				GD.Print("Target null");
			}else{
				GD.Print(target);
				GD.Print(target.GetPath());
				HBoxContainer t = (HBoxContainer) target;
				t.Show();
			}

			GD.Print("Bye");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
