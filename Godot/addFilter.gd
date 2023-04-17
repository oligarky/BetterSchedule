extends OptionButton


#Adds filters 
func _add_filter():
	var l = Label.new()
	var p=get_parent().get_child(3).get_child(0)
	var b= Button.new()
	p.add_child(l)
	l.text=text
	l.add_child(b)
	b.text="X"
	b.set_position(b.position + Vector2(132,0))
	b.set_script(load("res://removeFilter.gd"))
	l.clip_text=true
	l.text_overrun_behavior=TextServer.OVERRUN_TRIM_ELLIPSIS
	

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	pass
