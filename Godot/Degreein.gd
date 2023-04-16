extends HBoxContainer


# Called when the node enters the scene tree for the first time.
func _ready():
	degreeIn() # Replace with function body.

func degreeIn():
	var file = FileAccess.open("ParsedOutput.txt", FileAccess.READ)
	var content = file.get_as_text()
	var results = content.rsplit(" ", true)
	var length = results.size()
	


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
