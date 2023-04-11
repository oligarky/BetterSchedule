import PyPDF2
from PyPDF2 import PdfReader

reader = PdfReader("DegreeAudit.pdf")
number_of_pages = len(reader.pages)
parts = []


with open("Output.txt", "w") as f:
    for i in range(1,number_of_pages) :
        page = reader.pages[i]
        text= page.extract_text()
        print(text, file=f)
         
