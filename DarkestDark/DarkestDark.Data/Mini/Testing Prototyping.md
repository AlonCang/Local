====================
Testing Prototyping:
====================

I want to write a program that runs tests on the data.

Test cases:
1. Checks that all targetstates have corresponding states.
2. Checks that all transitions that belong to states exist.


Code Description:

- A class called "Test" that receives a "StateGraph" called "Graph".
- 

- It loads the Graph with data by using the "LoadStateGraph" function.
	- Paths to Mini Data files should be provided when the Class is instantiated in Program.cs
	
- The class has 3 functions:

	- "TestForTargetStates"
		- Receives "Graph"
		- Has a Dictionary from string to int called "TestResults"

		- foreach "Transition.TargetName" in "Graph"
			- if "Graph" Contains "State.Name"
			- "TestResults".add("TargetState", 1)
			- Else "TestResults".add("TargetState", 0)
			- Return "TestResults"

	- "TestForTransitions"
		- Receives "Graph"
		- Has a Dictionary from string to int called "TestResults" 

		- foreach "State.Transition.Name" in "Graph"
			- if "Graph" Contains "Transition.Name"
			- "TestResults".add("Transition.Name", 1)
			- Else "TestResults".add("Transition.Name", 0)
			- Return "TestResults"

	- "PrintTestResults"
		- Receives a Dictionary called "TestResults"
		- foreach Key in "TestResults"
			- ConsoleWriteLine($"{Key}: {Value}")