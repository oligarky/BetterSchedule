using Godot;
using System;
using System.Collections.Generic;
public partial class GenerateOptions : VBoxContainer
{
	private VBoxContainer getHead(){
		return this.GetParent().GetParent().GetChild(0).GetChild<VBoxContainer>(0);
	}

	private void optionfill(){
		List<Label> classes = new List<Label>();
		List<String> options = new List<String>();
		var ob=this.GetChild<OptionButton>(1);
		var head=getHead();
		var i = 0;
		var j=0;
		var hc=head.GetChildCount();
		while(i<hc){ 
			while(j<head.GetChild(i).GetChildCount()){
				classes.Add((Label)head.GetChild(i).GetChild(j));
				j++;
			}
			j=0;
			i++;
		}
		for(var ii=0;ii<15;ii++){
			options.Clear();
			List<String> stat= new List<String>();
			stat.Add("12 of 12");
			stat.Add("14 of 14");
			stat.Add("20 of 20");
			stat.Add("24 of 24");
			stat.Add("25 of 25");

			for(var jj=ii;jj<classes.Count-1;jj+=15){
				String match=classes[jj].Text;
				if(jj!=14&&ii==14 && stat.Contains(match)){
					match="Full";
				}else if(jj!=14&& ii==14){
					match="Space";
				}
				if(!(options.Contains(match))){					
					options.Add(match);
					if(jj<15){
						ob.AddSeparator(match);
					}else{
						ob.AddItem(match,jj+ii);
					}
				}
			}
			
		}
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		optionfill();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double _delta)
	{
	}
}
