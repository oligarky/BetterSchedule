extends VBoxContainer


# Called when the node enters the scene tree for the first time.
func _ready():
	scraper() # Replace with function body.



func scraper():
	OS.create_process("./Python311/python.exe", ["C:/Users/powellt1/Documents/GitHub/BetterSchedule/Godot/pdfscraping.py"])
