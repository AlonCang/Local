Darkest Dark.CLI

Repl

Loop: receives 2 arguments of type staterunner called “staterunner” and “overlayrunner”.

- Both have the same items. Both use the same Dictionary as data source. Hence are the same.
- While loop (!isgameover) to keep the game running.
    - Foreach loop to get the transitions from current overlayState. 
        - Print current state text
        - If (inventory)
            - check what items exist and save them as `actualItems`
            - all items in `actualItems` are saved as enumerable strings in `itemsWithDescriptions` 
            - print each of the elements of `itemsWithDescriptions`
        - If (journal)
            - filters journal entries and saves them
            - Convert them data into a string saved as `journal`
            - Remove the `@` from each elements name
            - print `journal` string
        - print 
      -    Print current state
      -    Print current state options with numbers before them
      -    Save player input
      -    If input = “quit” exit program
      -    Clear console
      -    Print player input
      
Check for legal overlay inputs
If boolean reverse psychology false
	- then print the overlay transition
	- else print the regular transition as text

Print how many items are there











I / 0 Breakdown:

Input: 
StateRunner stateRunner : StateRunner overlayRunner

Output:
If inventory then print all items + item text
If journal print the contents of journal (journal item names)
Print all current overlay options



Print current state
Print state options with numbers for each

If “quit”

Clear

Print player input

Check for overlay and….. PERFORM TRANSITION IS A BITCH!!! Too many things going on at the same time. Too much stuff gets moved around and reformed and interacts with each other. I can’t keep it all in my head until… i don’t know what comes out the other end of this, it relies on extra stuff i can’t follow BAH!  
Question: When transitionResultText receives the value of stateRunner.PerformTransition(choice).
Does it receive the value of the choice itself?
Or does it receive the value that PerformTransition returns?

I think that the second one is the correct one.
And so how is it that ConsoleWriteLine knows to print specifically the TEXT part
Of the currentstate that is returned from PerformTransition 
