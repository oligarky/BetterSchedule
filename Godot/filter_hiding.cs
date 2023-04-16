using Godot;
using System;
using System.Collections.Generic;

public partial class filter_hiding : Node
{

	//creating list for filtering
	List<Label> classes= new List<Label>();
	List<String> stat= new List<String>();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
		

		

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

	//Not working
	public void exfilter(List<String>[] fi){
		showAll();
		statManager();
		
		
		GD.Print("At ex");
		for(var j=0;j<classes.Count-1;j+=15){
			for(var t=0;t<15;t++){
				String filter = classes[j+t].Text;
				for(var i=0; i<15;i++){
					if(!(t%15==14)&&((fi[i].Count==0 && t%15==i)||(fi[i].Contains(filter) && t%15==i))){
						classes[j+t].GetParent<HBoxContainer>().Show();
						GD.Print(filter);
					}else if(j%15==14 ){
						if(!(stat.Contains(filter))&& (fi[14].Contains("Space"))){
							classes[j+t].GetParent<HBoxContainer>().Show();
						}else if(stat.Contains(filter)&& (fi[14].Contains("full"))){
							classes[j+t].GetParent<HBoxContainer>().Show();
						}
						
					}else{
						classes[j+t].GetParent<HBoxContainer>().Hide();
						//GD.Print(filter);
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
	private void statManager(){
		
		stat.Clear();
		stat.Add("12 of 12");
		stat.Add("14 of 14");
		stat.Add("20 of 20");
		stat.Add("24 of 24");
		stat.Add("25 of 25");
	}

	//Finds all classes that contain a given string and then hides those that don't have the matching string.
	//Called in FilterHandler.cs
	public void filterby(List<String>[] fi){
		//loops through all of the classes found in listLabels. ListLabes should be called first but will just not work as 
		//intended otherwise without an error.
		showAll();
		statManager();
		for(var j=0;j<classes.Count-1;j++){

			String filter = classes[j].Text;
			for(var i=0; i<15;i++){
				if(!(j%15==14)&& ((fi[i].Contains(filter) && j%15==i))){
					classes[j].GetParent<HBoxContainer>().Hide();
				}else if(j%15==14){
					
					
					if(!(stat.Contains(filter))&& (fi[14].Contains("Space"))){
						
						classes[j].GetParent<HBoxContainer>().Hide();
					}else if(stat.Contains(filter)&& (fi[14].Contains("Full"))){
						classes[j].GetParent<HBoxContainer>().Hide();
						
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
	//setup as a reset for the filters to allow for showing specific things
	public void showAll(){
		for(var j=0;j<classes.Count-1;j++){
			classes[j].GetParent<HBoxContainer>().Show();
		}
	}

	public void hideAll(){
		for(var j=0;j<classes.Count-1;j++){
			classes[j].GetParent<HBoxContainer>().Hide();
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
	public void Hides(String s,String n){
		//loops through all of the classes found in listLabels. ListLabes should be called first but will just not work as 
		//intended otherwise without an error.
		
		for(var j=0;j<classes.Count-2;j++){
			
			String filter = classes[j].Text;
			if((filter.Contains(s) && j%15==1)){
				
				if(classes[j+1].Text.Contains(n)){
					classes[j].GetParent<HBoxContainer>().Hide();
					
				}
				//shows the classes if they were hidden by another pass through from earlier filters
				//Might need to be changed later for additional filters
				
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
