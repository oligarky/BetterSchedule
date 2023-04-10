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
		//List<Label> classes= new List<Label>();
		//GD.Print(head.GetChild(i));
		var hc=head.GetChildCount();
		while(i<hc){ //could be for loop but not changed after findind the child count method
			//GD.Print(head.GetChild(i));
			//GD.Print(head.GetChild(i).GetChild(0));
			classes.Add((Label)head.GetChild(i).GetChild(0));
			
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
	
	//Finds all classes that contain a given string and then hides those that don't have the matching string.
	//Called in FilterHandler.cs
	public void filterby(String s){
		//loops through all of the classes found in listLabels. ListLabes should be called first but will just not work as 
		//intended otherwise without an error.
		for(var j=0;j<classes.Count-1;j++){

			String filter = classes[j].Text;
			if((filter.Contains(s))){
				//shows the classes if they were hidden by another pass through from earlier filters
				//Might need to be changed later for additional filters
				//classes[j].GetParent<HBoxContainer>().Show();
				GD.Print(classes[j].GetParent<HBoxContainer>());
			}else{
				//Hides the HBoxContainer instead of the label to clean up the output
				classes[j].GetParent<HBoxContainer>().Hide();
				
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
