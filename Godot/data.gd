extends VBoxContainer

# Called when the node enters the scene tree for the first time.
func _ready():
	load_csv()

func load_csv():
	var file = FileAccess.open("res://Comp_courses_data(1).csv", FileAccess.READ)
	var content = file.get_as_text()
	var results = content.rsplit(",", true)
	var length = results.size()
	
	var counter = 0
	var counter2 = 0
	
	for j in range(80):
		var hbox = HBoxContainer.new()
		add_child(hbox)
	
	for i in range(length):
		var label = Label.new()
		get_child(counter2).add_child(label)
		get_child(counter2).get_child(counter).text = results[i]
		get_child(counter2).get_child(counter).size_flags_horizontal += SIZE_SHRINK_BEGIN
		get_child(counter2).get_child(counter).size_flags_vertical += SIZE_SHRINK_CENTER
		sizing(counter,counter2)
		
		counter = counter + 1
		if fmod(counter, 15) == 0:
			counter2 = counter2 + 1
			counter = 0
			
	file = null
	
func sizing(counter, counter2):
		match counter:
			0:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(500,5))
			1:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(200,5))
			2:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
			3:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
			4:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
			5:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
			6:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(150,5))
			7:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(280,5))
			8:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(150,5))
			9:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(180,5))
			10:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(180,5))
			11:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(180,5))
			12:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
			13:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(300,5))
			14:
				get_child(counter2).get_child(counter).set_custom_minimum_size(Vector2(80,5))
