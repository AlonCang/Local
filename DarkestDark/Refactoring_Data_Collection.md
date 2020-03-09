
DarkestDark Refactoring Data collection
-----------------------------------------------

Class Files:
	- Program.cs
	- Repl.cs
	- State.cs
	- StateGraph.cs
	- StateRunner.cs
	- Transition.cs

Data Files:
	- A WHOLE BUNCH OF JSON FILES



PARSING:
-----------

Program.cs:
-------------
Classes:
	- Program: Has 1 function.
		- Main:
			* Has an instance of StateGraph and StateRunner (+overlay :P ).
			* Receives a list of strings and handles print protocols.




Repl.cs:
---------
Classes:
	- Repl: Has 1 function.
		- Loop:
			* Receives a StateRunner (+overlay).
			* While loop(IsGameOver).
			* Returns user string input.




State.cs:
---------
Classes:
	- State: Has 3 fields, 1 Constructor and 1 function.
		- Fields:
			* Name.
			* Text.
			* List of strings called “Transitions”.
		 -   Constructor:
			* Name.
			* Text.
		- Function:
			- ToString:
					* Returns a string that represents the current object
					  (Not sure about this. Does it just read the json files and then turn the datatype to string?)




StateGraph.cs:
----------------
Classes:
	- StateGraph: Has 2 fields, 2 void functions and 1 method:
 		- Fields:
			* A dictionary of States
			* A dictionary of Transitions
		- Void functions:
			- AddStates:
				* Receives a path to a json file
				* Returns the States in the file
			- AddTransitions:
				* Receives a path to a json file
				* Returns the Transitions in the file
		- Method:
			- LoadStateGraph: This one was hard but i think i got it.
				* Receives a path to both the States and Transitions Json files.
				* Has a StateGraph called “result”.
				* Inputs the json data into “result”.
				* Returns “result”.




StateRunner.cs:
-----------------
Classes: 
	- StateRunner: Has 4 fields, 1 constructor and 5 functions
		- Fields:
			* A StateGraph called “Graph”
			* A State Called “CurrentState”
			* A Boolean called “IsGameOver”
			* A Dictionary of Strings and Ints called “Items”
		- Constructor:
			* Receives a StateGraph called “graph” and a String called “initial”
			* Creates an instance of a dictionary called “Items”
			* Add the “initial” string into the “Items” dictionary
		- Functions:
			- GetCurrentState:
					* Returns a String prompt with the name & text of the current State
			- GetCurrentTransitions:
					* Has a list called “result”
					* Reads the “CurrentState” transitions
					* Checks that transition is legal
					* Adds transition to “result”
					* Returns “result”
			- PerformTransition: 
					* Receives a string called “transition”
					* Checks if “Graph” contains “transition”
					* Has a Transition called “tobj” and assigns “transition”s value to it
					* Pulls the Transition name from the data
					* Sets terms for “GAME OVER”
					* Collects transition items if available
					* Returns the text of “tobj” or “Bad Input” prompt
			- IndexToTransition: Not sure about the wording in this one
					* Receives a String called “indexString”
					* Collects legal transitions turns them to ints and puts them in “indexString”
					* Returns “indexString”
			- KeyToTransition: Also this one
					* Receives a String called “keyString”
					* Collects legal transitions, turns them into upper case and puts them in “keyString”
					* Returns “keyString”




Transition.cs:
---------------
Classes:
	- Transition: Has 5 fields, 1 boolean and 1 function:
		- Fields:
			* A String called “Name”
			* A String called “Text”
			* A dictionary of Strings and Ints called “Conditions”
			* A dictionary of Strings and Ints called “Items”
			* A String called “TargetName”
		- Boolean IsLegal:
			* Receives a dictionary of Strings and Ints called “items”
			* Checks legality
			* Returns “true” if legal
		- Function:
			- Tostring:
				* Returns class field values as part of a string prompt 



