import pandas as pd
import re

#Parsing line by line fed to it by code lower down
def _line_parse(line):
   line_data=[] #setup to allow saving the matches through multiple runs
   match = re.search(r'(Yes|No)',line) #searches for either Yes or No in the line
   if match: #if it finds a match it gets saved in the line_data and then serches the same line for the course name
        line_data.append(match[1])
        match = re.search(r' (([A-Z]{4})|^(YEAR)|(FYS)|^(ELEC)) ',line)
        if match: #if course name gets found it saves that and then searches for the course number
            line_data.append(match[0])
            match = re.search(r'[0-9]{4} ',line)
            if match: #if that gets found it then saves it and returns the line_data
                line_data.append(match[0])
                return line_data
   return None

data = [] # data list, should just be Yes|No, [course name], [course number]
datas = pd.DataFrame #setup to be able to use outside the while loop for file saving
with open("Output.txt", 'r') as file_object:
    line = file_object.readline() #gets the data from the output of the scraper
    while line:
        line_data= _line_parse(line) #sends the line to the parser
        if line_data != None: #if there is a match for the line it adds it to the data list
            data.append(line_data)
        line = file_object.readline() #gets the next line from the file
    datas = pd.DataFrame(data) #adds the data to the dataframe from pandas
datas = datas.to_csv(columns=None,index=None,header=None)
#print(datas)
with open("ParsedOutput.txt", "w") as f:
    print(datas, file=f) #prints the dataframe to the file
