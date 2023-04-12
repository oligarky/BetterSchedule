using Godot;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class FilterHandler : Node
{
	List<Label> filters=new List<Label>();
	List<String> tfilters=new List<String>();
	List<String> sfilters=new List<String>();
	List<String> cfilters=new List<String>();
	List<String> sefilters=new List<String>();
	List<String> hfilters=new List<String>();
	List<String> crfilters=new List<String>();
	List<String> terfilters=new List<String>();
	List<String> infilters=new List<String>();
	List<String> mdfilters=new List<String>();
	List<String> mtsfilters=new List<String>();
	List<String> mtefilters=new List<String>();
	List<String> bfilters=new List<String>();
	List<String> rfilters=new List<String>();
	List<String> cafilters=new List<String>();
	List<String> stfilters=new List<String>();
	List<String> Title=new List<String>();
	List<String> Subject= new List<String>();
	List<String> Course= new List<String>();
	List<String> Section= new List<String>();
	List<String> Hours= new List<String>();
	List<String> CRN= new List<String>();
	List<String> Term= new List<String>();
	List<String> Instructor= new List<String>();
	List<String> Meeting_Day= new List<String>();
	List<String> Meeting_Time_Start= new List<String>();
	List<String> Meeting_Time_End= new List<String>();
	List<String> Building= new List<String>();
	List<String> Room= new List<String>();
	List<String> Campus= new List<String>();
	List<String> Status= new List<String>();


	bool exclusive=false;

	public async void get_filter(){
		await Task.Delay(1);
		
		tfilters.Clear();
		sfilters.Clear();
		cfilters.Clear();
		sefilters.Clear();
		hfilters.Clear();
		crfilters.Clear();
		terfilters.Clear();
		infilters.Clear();
		mdfilters.Clear();
		mtsfilters.Clear();
		mtefilters.Clear();
		bfilters.Clear();
		rfilters.Clear();
		cafilters.Clear();
		stfilters.Clear();
		filters.Clear();
		if(Subject.Count==0){
			get_options();
		}
		VBoxContainer vp = get_filter_parent();
		GD.Print("Getting filters");
		GD.Print("vp child count "+vp.GetChildCount());
		for(int i=0;i<vp.GetChildCount();i++){
			GD.Print(vp.GetChild(i));
			GD.Print(vp.GetChild<Label>(i).Text);
			if(vp.GetChild<Label>(i).IsVisibleInTree()){
				filters.Add(vp.GetChild<Label>(i));
			}
		}
		GD.Print(filters[0]);
		sortFilter();
	}

	public void exin(bool b){
		exclusive = b;
		get_filter();
	}
	
	private void sortFilter(){
		
		for(int i=0;i<filters.Count;i++){
			
			String match = filters[i].Text;
			if(Title.Contains(match)){
				tfilters.Add(match);
			}else if(Subject.Contains(match)){
				sfilters.Add(match);
			}else if(Course.Contains(match)){
				cfilters.Add(match);
			}else if(Section.Contains(match)){
				sefilters.Add(match);
			}else if(Hours.Contains(match)){
				hfilters.Add(match);
			}else if(CRN.Contains(match)){
				crfilters.Add(match);
			}else if(Term.Contains(match)){
				terfilters.Add(match);
			}else if(Instructor.Contains(match)){
				infilters.Add(match);
			}else if(Meeting_Day.Contains(match)){
				mdfilters.Add(match);
			}else if(Meeting_Time_Start.Contains(match)){
				mtsfilters.Add(match);
			}else if(Meeting_Time_End.Contains(match)){
				mtefilters.Add(match);
			}else if(Building.Contains(match)){
				bfilters.Add(match);
			}else if(Room.Contains(match)){
				rfilters.Add(match);
			}else if(Campus.Contains(match)){
				cafilters.Add(match);
			}else if(Status.Contains(match)){
				stfilters.Add(match);
			}
		}
		filter();
	}
	//runs everytime a filter is applied
	public void filter(){
		
		filter_hiding filter = new filter_hiding(); //importing method in C# for other scripts
		filter.listlabels(this.GetChild<VBoxContainer>(0));//This will need to be checked in final to make sure it is correct
		List<String>[] fi = {tfilters,sfilters,cfilters,sefilters,hfilters,crfilters,terfilters,infilters,mdfilters,mtsfilters,mtefilters,bfilters,rfilters,cafilters,stfilters};
		if(exclusive){
			GD.Print("Sending to exclusive");

			//filter.exfilter(fi);
		}else{
			GD.Print(Subject[0]);
			GD.Print(fi[1].Contains("COMP"));
			GD.Print("Sending to inclusive");
			filter.filterby(fi);//example used is COMP but will eventaully be finding the text from nodes elsewhere
		}
	}
	//Seperated for easier editing
	private VBoxContainer get_filter_parent(){
		GD.Print(this.GetParent().GetChild(1).GetChild<VBoxContainer>(0).GetChild(3).GetChild<VBoxContainer>(0));
		return this.GetParent().GetChild(1).GetChild<VBoxContainer>(0).GetChild(3).GetChild<VBoxContainer>(0);
	}

	private void get_options(){
		var ob=get_filter_parent().GetParent().GetParent().GetChild<OptionButton>(1);
		var obc=ob.ItemCount;
		String group="";
		for (int i=0;i<obc;i++){
			if(ob.GetItemText(i).Contains("Title")){
				group="Title";
			}else if(ob.GetItemText(i).Contains("Subject Description")){
				group="Subject";
			}else if(ob.GetItemText(i).Contains("Course")){
				group="Course";
			}else if(ob.GetItemText(i).Contains("Section")){
				group="Section";
			}else if(ob.GetItemText(i).Contains("Hours")){
				group="Hours";
			}else if(ob.GetItemText(i).Contains("CRN")){
				group="CRN";
			}else if(ob.GetItemText(i).Contains("Term")){
				group="Term";
			}else if(ob.GetItemText(i).Contains("Instructor")){
				group="Instructor";
			}else if(ob.GetItemText(i).Contains("Meeting Day")){
				group="Meeting_Day";
			}else if(ob.GetItemText(i).Contains("Meeting Time Start")){
				group="Meeting_Time_Start";
			}else if(ob.GetItemText(i).Contains("Meeting Time End")){
				group="Meeting_Time_End";
			}else if(ob.GetItemText(i).Contains("Building")){
				group="Building";
			}else if(ob.GetItemText(i).Contains("Room")){
				group="Room";
			}else if(ob.GetItemText(i).Contains("Campus")){
				group="Campus";
			}else if(ob.GetItemText(i).Contains("Status")){
				group="Status";
			}else if(group.Contains("Title")){
				Title.Add(ob.GetItemText(i));
			}else if(group.Contains("Subject")){
				Subject.Add(ob.GetItemText(i));
			}else if(group.Contains("Course")){
				Course.Add(ob.GetItemText(i));
			}else if(group.Contains("Section")){
				Section.Add(ob.GetItemText(i));
			}else if(group.Contains("Hours")){
				Hours.Add(ob.GetItemText(i));
			}else if(group.Contains("CRN")){
				CRN.Add(ob.GetItemText(i));
			}else if(group.Contains("Term")){
				Term.Add(ob.GetItemText(i));
			}else if(group.Contains("Instructor")){
				Instructor.Add(ob.GetItemText(i));
			}else if(group.Contains("Meeting_Day")){
				Meeting_Day.Add(ob.GetItemText(i));
			}else if(group.Contains("Meeting_Time_Start")){
				Meeting_Time_Start.Add(ob.GetItemText(i));
			}else if(group.Contains("Meeting_Time_End")){
				Meeting_Time_End.Add(ob.GetItemText(i));
			}else if(group.Contains("Building")){
				Building.Add(ob.GetItemText(i));
			}else if(group.Contains("Room")){
				Room.Add(ob.GetItemText(i));
			}else if(group.Contains("Campus")){
				Campus.Add(ob.GetItemText(i));
			}else if(group.Contains("Status")){
				Status.Add(ob.GetItemText(i));
			}
		}
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
