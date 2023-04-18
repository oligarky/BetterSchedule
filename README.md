A Better Schedule User Guide
Regular user:
NOTICE: In this program's current state it WILL NOT ask you for any of your Wentworth credentials but may require your computer password during the installation process to install the python packages. If you are asked to enter your Wentworth credentials anywhere but on the wit.edu websites do not enter it.

Installation:
Please download everything from the main branch of Github(https://github.com/oligarky/BetterSchedule).
After downloading it please put it where you would like it to be and unzip it.
Now the program should be able to be run and if you do not want to have any filters generated automatically you can use it as is now.
For a generated filter please go to your degree audit and print it as a pdf.
To do this as a Wentworth student go to myWentworth (myWentworth)
Then click on leopardWeb
Once the new menu is open click on student profile
On the left of the screen should be a link to degree evaluation
Select the appropriate term and scroll down to select the appropriate major
Then click generate new evaluation on the bottom of the screen
Now you should be on a webpage with your degree audit information.
Hit ctrl + P to open the print menu or however you prefer to print a webpage
For destination click on the dropdown menu and select “save to PDF”. There may be a few PDF options but the one that works best is “save to PDF”.
After obtaining your degree audit click the upload button inside the program.
Select the degree audit PDF from the window that pops up.
Wait until the alert pops up saying that the upload was complete.
You should now have an automatic filter applied to the course list and you can go through and select all of the courses you want to add to your schedule using the button next to the courses.
When you’re ready to get your schedule out for registration click on the export schedule button and it will give you JS code to make into a bookmark
To do this open your preferred browser and create a new bookmark from the bookmark manager.
Then instead of entering in a URL copy paste the JS code that the program gives you.
Now when you go to register simply get to the page where it asks you to enter CRNs and click on the bookmark button that you made and it will register the courses for you.

Filters:
Depending on if you have entered your degree audit information into the program there may be an automatic filter applied that removes all of the courses that the degree audit says you have completed.
More filters can be added using the right pane. Simply select it from the menu on the right pane then click add.
To remove a filter simply click on the button next to the filter. After removing the filter to rerun the filters click the “Apply Filter” button.

Developer:
Requirements
To open this in Godot the C# executable is necessary.
.Net appropriate for the Godot version downloaded is necessary.
Other requirements outlined for regular users.

Warnings:
If the data format is changed the data.gb function will need to be updated along with the filter_hiding.cs script.
The options are generated using the headers in the csv so you can add them there so long as other scripts are fixed.
