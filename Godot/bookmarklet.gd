extends VBoxContainer


# Called when the node enters the scene tree for the first time.
func _ready():
	bookmarklet() # Replace with function body.

func bookmarklet():
	var counter = 1
	var crns = [33861, 33862, 33867, 33868, 33877, 33878]
	var bms = "javascript:(function(){"
	for i in range(crns.size()) :
		var fs = 'document.getElementById("txt_crn%d").value = "%d";'
		var rs = fs % [counter, crns[i]]
		bms = bms + rs
		counter = counter + 1
		
	var bookmarklet = bms + "})();"
	
	print(bookmarklet)
