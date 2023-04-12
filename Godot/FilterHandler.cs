using Godot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class FilterHandler : Node
{
	List<Label> filters=new List<Label>();
	List<String> sfilters=new List<String>();
	List<String> bfilters=new List<String>();
	//List<String> cfilters=new List<String>();
	List<String> tsfilters=new List<String>();
	List<String> subject= new List<String>();
	List<String> Building= new List<String>();
	List<String> TimeStart= new List<String>();
	bool exclusive=false;

	public async void get_filter(){
		await Task.Delay(1);
		sfilters.Clear();
		bfilters.Clear();
		tsfilters.Clear();
		filters.Clear();
		VBoxContainer vp = get_filter_parent();
		GD.Print("Getting filters");
		GD.Print("vp child count "+vp.GetChildCount());
		for(int i=3;i<vp.GetChildCount();i++){
			GD.Print(vp.GetChild(i));
			GD.Print(vp.GetChild<Label>(i).Text);
			if(vp.GetChild<Label>(i).IsVisibleInTree()){
				filters.Add(vp.GetChild<Label>(i));
			}
		}
		GD.Print(filters);
		sortFilter();
	}

	public void exin(bool b){
		exclusive = b;
		get_filter();
	}
	
	private void sortFilter(){
		GD.Print("Starting sort");
		GD.Print(filters[0].Text);
		for(int i=0;i<filters.Count;i++){
			GD.Print("Sorting"+filters[i].Text);
			if(subject.Contains(filters[i].Text)){
				sfilters.Add(filters[i].Text);
				GD.Print("Adding to sfilters"+filters[i].Text);
			}else if(Building.Contains(filters[i].Text)){
				bfilters.Add(filters[i].Text);
				GD.Print("Adding to bfilters"+filters[i].Text);
			}else if(TimeStart.Contains(filters[i].Text)){
				tsfilters.Add(filters[i].Text);
				GD.Print("Adding to tsfilters"+filters[i].Text);
			}
		}
		filter();
	}
	//runs everytime a filter is applied
	public void filter(){
		
		filter_hiding filter = new filter_hiding(); //importing method in C# for other scripts
		filter.listlabels(this.GetChild<VBoxContainer>(0));//This will need to be checked in final to make sure it is correct
		
		if(exclusive){
			GD.Print("Sending to exclusive");
			filter.exfilter(sfilters,bfilters,tsfilters);
		}else{
			GD.Print("Sending to inclusive");
			filter.sfilterby(sfilters,bfilters,tsfilters);//example used is COMP but will eventaully be finding the text from nodes elsewhere
		}
	}
	//Seperated for easier editing
	private VBoxContainer get_filter_parent(){
		return this.GetParent().GetChild(1).GetChild<VBoxContainer>(0);
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var ob=get_filter_parent().GetChild<OptionButton>(1);
		var obc=ob.ItemCount;
		String group="";
		for (int i=0;i<obc;i++){
			if(ob.GetItemText(i).Contains("Subject")){
				group="Subject";
			}else if(ob.GetItemText(i).Contains("Building")){
				group="Building";
			}else if(ob.GetItemText(i).Contains("Start time")){
				group="Start time";
			}else if(group.Contains("Subject")){
				subject.Add(ob.GetItemText(i));
			}else if(group.Contains("Building")){
				Building.Add(ob.GetItemText(i));
			}else if(group.Contains("Start time")){
				TimeStart.Add(ob.GetItemText(i));
			}
		}

		// subject.Add("COMP");
		// subject.Add("MATH");
		// subject.Add("HUSS");
		// subject.Add("HUMN");
		// subject.Add("HIST");
		// Building.Add("Wentworth Hall");
		// Building.Add("CEIS");
		// Building.Add("Beatty Hall");
		// Building.Add("Online Section");
		// Building.Add("Dobbs Hall");
		// Building.Add("Annex Central");
		// Building.Add("Annex South");
		// Building.Add("Rubenstein Hall");
		// TimeStart.Add("09:30:00");
		// TimeStart.Add("10:00:00");
		// TimeStart.Add("08:00:00");
		// TimeStart.Add("14:00:00");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
