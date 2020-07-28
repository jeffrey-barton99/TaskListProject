using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

create method for each action.

int menuSelection = -1;
while (menuSelection !=0)

Design
windows console app .netcore
need to be able to read and write from a file
basic logic from public menu class
CosnoleColorTextTest()
multiple arrays of tuples or 2 seperate arrays
tracking them
ascii records seperator
structure for holding a list.  
so a struct inside of the list.
switch

Create a task list that accepts user input and displays / runs from console and pulls from/ writes to file.
1. Build the list.
-First, ask for input string from user ordered by entry instructing user to hit enter after each entry.
-Then, receive input string from user displayed in order of entry.
-After received input string, ask user if there are any more entries y/n.
  -if y
    -then, receive input string from user displayed in order of entry
  -else 
  -confirm final receipt from the user. (list build completed)  
  once confirmed
-display list  

2. Display list.
Display the list to windows column.
 Highlighted task = foreground and background reversed.
 Marked out task = marked out and dark gray foreground. Can we line out text?  Dark
 gray if now.
 Skipped task = display task w/dark gray not marked out.
 Actions on task = interrogative. Task worked to completion, or started, but not finished. y/n
 Task Complete = task completion message.
   -list received items in order entered. 
       -no more than 15 tasks per page
   -begin at the top of the list.  
     -Highlighted task.

   3. Receive commands from the user
     -Ask user if current task is complete.  y/n 
       -if yes, Marked out task 
	      -then move to next task on the list.
	    -else 
           Actions on task
       -if y 
	     -remove task from list
            -remove marked out item
              -if no item above it.
       -else
          -else = skipped task	
	   -move to next task on the list.  
       	-return to beginning of #3.   

   4. Update the list based on user commands
     -see all in #3.


   5. Display updated data.
      -see all in #4.

   6. Task list Complete
     -When reach 1 item left on the list
     -confirm completion
        -offer to receive additional input string y/n.
          -if y, return to 1.
        -else
       display Task Complete
press any key to quit
   
   list class vs char. 