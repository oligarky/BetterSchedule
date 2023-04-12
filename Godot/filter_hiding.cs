using Godot;
using System;
using System.Collections.Generic;

public partial class filter_hiding : Node
{

	//creating list for filtering
	List<Label> classes= new List<Label>();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//listlabels();

		

	}
	//Moves through the tree of nodes to find all of the labels 
	public void listlabels(VBoxContainer head){
		//GD.Print("Listing");
		//GD.Print(head);
		var i = 0;
		var j=0;
		//List<Label> classes= new List<Label>();
		//GD.Print(head.GetChild(i));
		var hc=head.GetChildCount();
		GD.Print(hc);
		GD.Print(head.GetChild(0).GetChildCount());
		while(i<hc){ //could be for loop but not changed after findind the child count method
			//GD.Print(head.GetChild(i));
			//GD.Print(head.GetChild(i).GetChild(0));
			while(j<head.GetChild(i).GetChildCount()){
				classes.Add((Label)head.GetChild(i).GetChild(j));
				j++;
			}
			j=0;
			i+=1;
			//GD.Print(i);
		}
		//foreach (Label n in classes){
			//GD.Print(n);
		//}
		//GD.Print("End list");

	}
	//still attached to the button but does nothing, should be removed in cleaning
	public void _on_pressed()
	{
		//listlabels();
	}

	
	public void exfilter(List<String> s,List<String> b, List<String> ts){
		showAll();
		var si=1;
		var tsi=9;
		var bi=11;
		
		for(var i=0;i<classes.Count-1;i+=15){
			
			
			if(s.Count==0 || s.Contains(classes[i+si].Text)){ //either s is nothing or it matches
				if(b.Count==0 || b.Contains(classes[i+bi].Text)){ //either b is nothing or it matches
					if(ts.Count==0 || ts.Contains(classes[i+tsi].Text)){ //either ts is nothing or it matches
						classes[i].GetParent<HBoxContainer>().Hide();
					}
				}
			}
		}
		for(var j=0;j<classes.Count-1;j++){
			
			if(classes[j].GetParent<HBoxContainer>().IsVisibleInTree()){
				classes[j].GetParent<HBoxContainer>().Hide();
			}else{
				classes[j].GetParent<HBoxContainer>().Show();
			}
		}
	}


	//Finds all classes that contain a given string and then hides those that don't have the matching string.
	//Called in FilterHandler.cs
	public void sfilterby(List<String> s,List<String> b, List<String> ts){
		//loops through all of the classes found in listLabels. ListLabes should be called first but will just not work as 
		//intended otherwise without an error.
		showAll();
		var si=0;
		var tsi=0;
		var bi=0;
		for(var j=0;j<classes.Count-1;j++){

			String filter = classes[j].Text;
			if((s.Contains(filter) && si%15==1)){
				//shows the classes if they were hidden by another pass through from earlier filters
				//Might need to be changed later for additional filters
				//classes[j].GetParent<HBoxContainer>().Show();
				classes[j].GetParent<HBoxContainer>().Hide();
			}else if(b.Contains(filter) && bi%15==11){
				classes[j].GetParent<HBoxContainer>().Hide();
			}else if(ts.Contains(filter) && tsi%15==9){
				classes[j].GetParent<HBoxContainer>().Hide();
			}
			si++;
			tsi++;
			bi++;
		}
		for(var j=0;j<classes.Count-1;j++){
			
			if(classes[j].GetParent<HBoxContainer>().IsVisibleInTree()){
				classes[j].GetParent<HBoxContainer>().Hide();
			}else{
				classes[j].GetParent<HBoxContainer>().Show();
			}
		}


	}
	//setup as a reset for the filters to allow for showing specific things
	public void showAll(){
		for(var j=0;j<classes.Count-1;j++){
			classes[j].GetParent<HBoxContainer>().Show();
		}
	}
	//This just does the unhiding not any filtering beyond that. Can be used during later filtering to ensure things are shown
	public void unHide(String s){
		//loops through all of the classes found in listLabels. ListLabes should be called first but will just not work as 
		//intended otherwise without an error.
		for(var j=0;j<classes.Count-1;j++){

			String filter = classes[j].Text;
			if((filter.Contains(s))){
				//shows the classes if they were hidden by another pass through from earlier filters
				//Might need to be changed later for additional filters
				classes[j].GetParent<HBoxContainer>().Show();
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
