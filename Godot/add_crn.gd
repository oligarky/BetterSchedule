extends HBoxContainer

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass


func getDay(c):
	if c == 0:
		pass
	else:
		pass
	
func getData(crn):
	pass
	
func getCRN():
	var node = get_node("Head2/VBoxContainer/LineEdit")
	var crn = node.text
	getData(crn)
	
func getLabel():
	var node = get_node("Head2/LineEdit")
	if node.text == "33814":
		var c1 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Fri/GridContainer/10am")
		var c2 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Fri/GridContainer/11am")
		var l1= Label.new()
		var l2= Label.new()
		c1.add_child(l1)
		c2.add_child(l2)
		l1.text=node.text
		l2.text=node.text
	elif node.text == "33813":
		var c1 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Mon/GridContainer/9am")
		var c2 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Mon/GridContainer/10am")
		var c3 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Wed/GridContainer/9am")
		var c4 = get_node("CalendarVBox/CalendarScroll/CalendarHBox/Wed/GridContainer/10am")
		var l1= Label.new()
		var l2= Label.new()
		var l3= Label.new()
		var l4= Label.new()
		l1.text=node.text
		l2.text=node.text
		l3.text=node.text
		l4.text=node.text
		c1.add_child(l1)
		c2.add_child(l2)
		c3.add_child(l3)
		c4.add_child(l4)

	
	
	

	
	
