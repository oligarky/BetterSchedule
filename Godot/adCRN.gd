extends LineEdit


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
	
func _add_text():
	var l = Label.new()
	var p=get_parent()
	var b= Button.new()
	p.add_child(l)
	l.text=text
	l.add_child(b)
	b.text="X"
	b.set_position(b.position - Vector2(20,0))
	b.set_script(load("res://removeFilter.gd"))

