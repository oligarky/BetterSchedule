import PyPDF2
from PyPDF2 import PdfReader

reader = PdfReader("Degree evaluation record2.pdf")
number_of_pages = len(reader.pages)
parts = []

# def visitor_body(text, cm, tm, font_dict, font_size):
#     y = tm[5]
#     if y > 900  and y < 1900:
#         parts.append(text)

# vb = visitor_body

with open("Output.txt", "a") as f:
    for i in range(1,number_of_pages) :
        page = reader.pages[i]
        text= page.extract_text() #visitor_text=vb
        # text_body = "".join(parts)
        print(text, file=f) #text_body
    

    
