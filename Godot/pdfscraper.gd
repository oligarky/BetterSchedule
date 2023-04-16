extends AcceptDialog


# Called when the node enters the scene tree for the first time.
func _ready():
	pass




func scraper(path):
	var pid=OS.create_process("./Python311/python.exe", ["./pdfscraping.py",path])
	print(pid)
	while OS.is_process_running(pid):
		pass
	var pid2=OS.create_process("./Python311/python.exe", ["./parse.py"])
	print(pid2)
	while OS.is_process_running(pid2):
		pass
	popup_centered()

