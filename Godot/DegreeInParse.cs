using Godot;
using System;
using System.IO;
using System.Collections.Generic;

public partial class DegreeInParse : VSplitContainer
{
	List<String> dinfo = new List<string>();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public void import(){
		String f = "ParsedOutput.txt";
		GD.Print(File.Exists(f));
		if(File.Exists(f)){
			using (StreamReader sr = File.OpenText(f)){
				string s;
				while((s = sr.ReadLine()) !=null){
					dinfo.Add(s);
				}
			}
		}
		
		parse();

	}

	private void parse(){
		filter_hiding hider = new filter_hiding();
		hider.listlabels(GetChild(0).GetChild(0).GetChild<VBoxContainer>(0));
		for(int i=0;i<dinfo.Count-1;i++){
			String[] tohide = dinfo[i].Split(",");
			if(tohide[0].Contains("Yes")){
				hider.Hides(tohide[1].StripEdges(),tohide[2].StripEdges());
			}
		}
	}
	private void printall(){
		for(int i=0;i<dinfo.Count-1;i++){
			
			GD.Print(dinfo[i]);
		}
	}



	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
