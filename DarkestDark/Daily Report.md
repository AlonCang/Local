Saturday 25/04/2020:
------------------------
1. Added the 1st scene of the final level.
		- States and transidions have been added.
		- Still need to place items and journal entries.
		- Also i need to place the whole final scene.

2. Starting my  testing automation course.
				- 1st 3 lessons completed. Those were just the overview.
				- Looks like this course will be using a free program called "Selenium". My google search claims this is a very poopular tool ith good credits. Thats what google says.

Friday 24/04/2020:
-------------------
1. Tried coming up with new features for the program.
	- Anything that i came up with i ended up discarding because none of it was essential for the program.
	- I think that at some point i "COULD" develope conditions for items:
		- This could be an addition to the current conditions system or an entirely new function.
		- It could be a function that receives a transition, checks for the existence of an item or a journal entry (also item i know).
		  Then depending on the result it will grant the player an item/journal entry from a list, or both.. i dont know.
		- Somehow i feel that this is already how the system works anyway. 
		- My assumption was to upgrade the 'PerformTransition' function. But after reading it i dont think that this is the right place.

2. I had a mental breakdown.
	- I has become doubt.
	- Recalibrated my brain.
	- CONCLUSION: 
			- DarkestDark has pretty much completed its functional requirements. I will not focus on developing anything new for it.
			- I will continue filling out the minimal data required in order to move on to the next phase.
			- NEXT PHASE: Use DarkestDark as a test subject in order to learn Test automation.
			- QUESTION: Correct me if im wrong but it seems that test automation is rather expensive. Does that mean that only large companies can afford it?
					- If so does that mean that my lack of official training (and older age) would be a sever detriment to my ability to get hired?
					- Are there even jobs for people like me in Israel?
					- Should i start looking for work online in other countries?
					- Will i be able to feed myself after my parents can no longer support me and the world descends into chaos?
					- Why is it that suicide is back on the list of legal transitions? :P
					- TOPKEK! Depressed humor is not funny! Use energy to improve self not hate self.
			
3. I have spent some time reading about test automation. Was not surprised to find that it is an entire field of study in itself with its	
	own methodologies, theories, programs, markets etc.
	- I will start some sort of online course to supplement sensei's teachings as sensei cannot be expected to teach me giant blocks of technical info.

4. REQUEST:
		- In these times of confusion. I would like to ask you for guidance. Is this indeed the time to transition away from learning general coding?
		- Am i again straying away from the correct path due to emotional imbalance? 
		- Career advise plox :( 
		
5. No more work for today. Most of my energy was spent in study and banter with self.
	- Thats ok though. Not all work results in lines of code.
	- Onwards to somesort of victory... some day... i hope...

Thursday 23/04/2020:
-------------------------
1. Placed journal entries on their corresponding transitions.
	- I have encountered an issue where the same transition could give 2 different journal entries when only one should be given based on a codition.
	- I need to think on how to extend the conditions system so it would fix this issue.
		- EXAMPLE: When the player finds ROBERTS HEAD, he should get a different journal entry depending or not if he has spoken to the ghoul about ROBERT.
		- My 1st guess is to go look at how the Conditions are currently working and then see how i extend the Items system to include the relevant code.
		- Its not very important at the moment since its not a must. But its nice to keep it in my head as an option.
		
2. Placing journal entry conditions on transitions. Got my work cut out for me. 

Wednesday 22/04/2020:
----------------------------
1. StateRunner.cs now has a new function called "BuildInventory". 
	- Its the same code copied from Repl.cs. Which now calls on this function in order to work the inventory.

Teusday 21/04/2020:
------------------------
1. All level 1 + 2 journal entries now exist in Journal Entries.json
	- I will do the flagging tomorrow. Have been sick most of the day.

Monday 20/04/2020:
------------------------
1. Spent the whole day with family. Holocaust eve brings people together... through ZOOM. crazy times.

Sunday 19/04/2020:
-----------------------
1. Added some items:
		- Now the grand hall on level 2 has doors that change name once you visit the rooms.
		- Inventory items have been placed all around the level
		- items.json has been updated with every new item.
		- All fight choices now cost items when chosen.
		- Tomorrow ill add journal entries and conditions. I expect that bug you mentioned to happen as soon as i set for more than 1 condition. Ill try and tackle it when it occurs. If i cant handle it ill contact you.
		- This is all coming out so nicely. Also i just realised while working on the data in the past few days that this sort of was my job in my last company. I did very little QA and a lot of data wiring. Only this time i like what im working on.
		

Saturday 18/04/2020:
-------------------------
1. Finished adding level 2 states and transitions.
	- Still nee to fill out the text for many of the states / transitions.
	- Tomorrow i will start flagging for items (visited rooms, inventory items & journal entries).
	- OMG! I'v been planning this project for so long and its now finally starting to take shape. Im excited. :D 

Friday 17/04/2020:
----------------------
1. Added more level 2 data:
	- Almost completed adding all states and transitions.
	- No items or journal entries made yet.
	- Shadow conversation needs more work.
	- Gargoyle fight needs more work.

Thursday 16/04/2020:
-------------------------
1. Started adding level 2 data.
	- Encountered a bug. Since the combat is simply choices. when choosing to use a weapon you get transitioned into the inventory but on the regular staterunner (not overlay).
	- I think this is because we made those item states + transitions that we ended up not using. I think i can remove them without issue, but ill get to it later.
	- So iv been at it for a few hours. Thats good enough for now. Gonna push.

Wednesday 15/04/2020:
----------------------------
1. Added some journal entries to the data.
2. Rewrote inventory with a foreach loop and it works!
3. Now lesson shall begin, more shall be done today. 
HOMEWORK:
4. Moral System: 
		- Map the 1st level for moral paths using the conditions + items system.
5. For now the MAP FEATURE is not relevant simply because its too needlessly complicated to make in a console app. 
6. Build level 2 using the current system.
WISDOM: If i get confused it means i probably havent read the code correctly.
7. did some code declattering

Teusday 14/04/2020:
------------------------
1. Make the journal print like the inventory:
	- Technically like you said i can sort of copy the printing protocol from inventory.
	- HOWEVER! Inventory is using Select() to access the string, int kvp.
	- Journal is a string, string (name + text). So i dont think i can use Select() for this. Ill see what i can do.
	- Commiting changes hoping master wll help
		- rewrite the journal code so it would be broken down to step by step using foreeach loops
		- Do the same for inventory

Thursday 09/04/2020:
-------------------------
1. Added Transition breakdown file - With Questions
2. Added StateRunner breakdown file
3. Added StatGraph breakdown file - With commentary
4. Wondering if i should start focusing on QA automation or keep on focusing on general programing. 


Wedneday 08/04/2020:
---------------------------
1. Added State breakdown file
2. SEDER PESAH ONLINE!!! 

Teusday 07/04/2020:
------------------------
Homework:
1. Break down the following classes:
	- State.cs
	- Transition.cs
	- StateRunner.cs
	- StateGraph.cs
	

Monday 06/04/2020:
------------------------
1. Sent sensei the code breakdown of Repl.cs

Sunday: 05/04/2020:
-----------------------
1. Tried to figure out the problem from yesterday.
2. Cried to master.
3. Got advice and broke down the code line by line in a seperate document.
	- Tried on paper. Made a mess,
	- Tried making a google doc flowchart. Made a mess.
	- Tried paper again. Made less of a mess. But i have found out what i dont get.
	PROBLEM: In Repl.cs: Perform transition() is too complicated for me. So many ifs and stuff. I cant figure out how the output of this
					   thing even looks. 
	QUESTION: How does the outout of this thing works? I get everything except for way "choice" is handled and returned from performtransition().
	
Saturday 04/04/2020:
------------------------
Darkest Dark:
1. Organised the states and transition into files for better project navigation.
2. Item states plan and proccess:
	- So i think i will make an Overlay Items file for overlay item states and a file for overlay item transitions.
	- This way i can make them without changing anything in the current items file. Lets see how this works out.
	- Already iv encountered issues. The "Inventory" state needs to contain transitions to all available items.
	- Also those transitions should only be printed if the item value == 0. So i need to set a condition. Lets hope this works.
	- Ok iv managed to make a working item state. Only "Issue" currently is that in order for it to be available comfortably, i need to make it belong to the inventory state.
	- So ill start with that and then we will fix the formatting later.
	- Ok soooo..... Good news it works.
	- Bad news its a fucking mess. Shit is getting multi printed even when not wanted.
	- There are too many systems working simultaniously. I cant get my head around it right now. But im digging this.
	- I had to get through a bunch of bugs to get this to work but all in all it wasn't impossible.
	- So iv reviewed the Repl.cs and i think that in order to get things printed correctly i will need:
			- Steal the printing protocol for the regular states and their transitions and put it into the overlay.
			- Make it so that each item get a number printed before it just like the regular transitions.
			- Make it so that when inventory is open then regular transitions are not accessible (to prevent a number meaning 2 different transitions "regular/overlay")
			- I think there wont be a need anymore for the kvp thingy that prints the item text in the inventory since thats what the item state is for.
			- Ill be honest, im scared of messing around with Reple.cs on this level since i dont really know whta im doing. ould be happy to get a review for my plan before i go fiddling around.
			- When all of this is working i will pretty much copy paste it for the journal since the functionality is almost identical.

Friday 03/04/2020:
---------------------
1. Reviewed the 2 commits that sensei made.
	- Checked line by line and followed the functionality.
	- Those are a lot of tweaks, but im glad i was in the right direction.
	- Lel "w" != "W" :P
	- some marked code pieces (on github) are actually unchanged. Did you erase and remake them?
	- I saw that you removed a white space on Reple.cs line 27. I thought that C# is not white space sensitive. Or is it just for cleaner looking code?
	- I see that making the List<Recipe> takes the required functionality from the stategraph.cs. It only really nees to hold the data itself ithout further stuff.
	- And yes now the LoadRecipes function works as intended. So smooth, so clean. 
	
2. Ill take on the journal and item sates tomorrow. 

Thursday 02/04/2020:
-------------------------
Factorio.Mess:
1. Made my attempt at making the  static function for Recipe.cs. 
	- Broke down the code step by step.
	- Used Json reading functions from StateGraph.cs as reference for my code.
	- Encountered bugs that i couldn't resolve. (Please check Factorio.Mess Recipe.cs)
	
 Darkest Dark:
1. Created some fluf text for the existing items in the inventory.
	- There is a bug. While opening the inventory all texts for items are printed next to them. Except for "Holy Water" which gets no text printed. 
	   I cant tell why though. No error is mentioned and the code isnt different for this perticular item.
	- How do i make a state for each item? Or more accurately, WHERE do i put those ItemStates? Do i make a new file? do i put them in States.Json? does it matter?
	- Do i need to make any updates to the machine in order for this to work or can i simply use it as is?

2. Added a couple of journal items.
	- How do i make it so that the journal will be printed like the inventory? Shouldi just copy the code? 
	   
3. did a tiny bit of formatting on how things are printed.
WISDOM:
------------
Remember wisdom for life. Whenever you try to make anything in code, try to think what would be the most minimal way that it could be represented in code
and then work from there. Add any missing pieces in order to most accurately represent the thing that you want to do. WISDOM

Wednesday 01/04/2020:
----------------------------
HW for Thursday. Give success or questions. Like Readstategraph but readrecipes[].
1. Write a static function for Recipe.cs that receives a path to a file and returns a list of recipes.
2. Fill up the DarkestDark data that is missing. 

ANYTHING IS BETTER THAN NOTHING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

Wednesday 24/03/2020:
-----------------------------
HW leftovers:
1. Practice where() and select()
2. Verify journal functionality and keep developing.
3. We talked about recursion
4. Figure out how nathan built the journal and apply it in the game via new data.
5. Use the same conditions + items structure to develope the next feature (Moral progress).
6. When pulling the git from nathan, stash my own files if needed, then pull, then "pop" the stash. Might get conflict.
7. We now have a state machine in Factorio.Mess
8. Organize the DarkestDark states and transitions into orderly files. 
9. DD: Develope text for items (The same can be done for journal items):
		- 1. State Per Item
		- 2. Transition to Item per Item
			- 2.1 Condition: Have Item
		- 3. Transition to Inventory (from item)

Teusday 24/03/2020:
------------------------
1. DarkestDark: I want to make it so that when an item is used, its kvp value goes down by 1 int.
	- So i think i need to set a condition that if transition requires an item, when that transition is chosen it makes the value of the item go down by 1
	- Now to locate where that thing happens in the code.
	- Turns out it was alreay implemented and i just had to learn it.
2. Made a journal state. It works exactly like the inventory. Ill make a tweaked version of the items being added for the journal entries.
3. Factorio.Mess: Added the furnace and its required supplements. It should work now but i cant test it since im faultering with the else if bullshit to get it done in game.
	
Monday 23/03/2020:
-------------------------
1. Organize the factorio.mess project to files - DONE
2. New DarkestDark inventory fixes work great. Next thing is making it so that /// items.kvp.value -1 /// when used.
3. Reviewed time related code on factorio.mess, have yet to implement the MinedSoFar() function.
4. Reviewed the Exercise program.cs file. Was able to read it and sort of understand it in general. But the mechanical operations are still very confusing. Ill have to work on it more to get anywhere.
5. Journal will have to wait. Simply because FUCK.
6. Furnace will have to wait because FUCK.
7. GAME OF LIFE can be removed from this list until more FUCKs have been delivered from Spain.
8. Writing a calculator seems like an awesome little project that absolutely should do. Soon. But it is not this day.
9. Read about recusion functions in C#. Had to also learn about factorials since i have never heard of them before. Now i know why there was a ! buttom on my school calculator. 


Wednesday 18/03/2020:
-----------------------------
HOMEWORK:
1. Practice "Where()" by reading about arrays and lists in C# and trying different IEnumerables
2. "Select()" is like where but instead of filtering members, it changes their data type and makes a new list containing the new members
3. Apply some inventory usage to verify functionality.
4. Develope Journal feature.
5. Factorio mess: Go over the time settings.
6. Check Program.cs and follow instructions.
7. Develope Furnace.
8. Organize the project to files.
9. Take another look at GAME OF LIFE. 
10. Try writing a console calculator (TIP: Make the calculator in prefix notation "+ 1213423")
11. READ ABOUT RECURION FUNCTION 

Teusday 17/03/2020:
------------------------
1. Reviewed new code and notes.
2. Fine i wont be messing with time.
3. Im setting a loop counter for the factorio.mess so i could keep track of the number of loops in each run (Instead of timer).
4. Currently there is a bug with the 3rd option (View Resources). when you choose to mine for coal it adds 1 coal AND 1 iron. Ill try to fix that.
5. Nope that wasnt the issue... Im just not printing the right stuff. I need to get the 3rd option to acutally print the number of each resource... hmmm....
6. I tried 6 different things. Couldnt none of them to work:
	- I tried making an inventory class that holds the current number of each resource. But i couldnt get it to work.
	- I tried doign something similar with a function but had syntax / context issues.
	- I tried playing with the CW output but couldnt get it to print what i want.
	- I tried to overhaul the class structure so that resources.... nvm i dont know what i was trying to do there... Just a mess. UNDO!
	- I tried writing a resource printer function that just keeps track of the contents of the resources dictionary and prints them. Failed again.
	- I tried changing the return from the MineCoal() + MineIron() functions so that instead of returning a new resource, it would add +1 to the value of that resource in the resources dictionary. Coudnt get it to work. BAH!

7. moving back to DarkestDark. Need to make the inventory there work properly...
8. Ok. I think i got it. Now it prints what i want.
9. Just need to remove the stuff that is no longer necessary, but ill wait for our meeting before i remove stuff.
10. Im really happy, it took way more thinking and proding to figure out the simple answer 
Sunday 15/03/2020:
-----------------------
1. Working on FactorioMess project because im stuck on the main one.
2. I want to implement a timer in the game so that drills will make resources every fe seconds.
3. Spent 2 hours trying to follow tutorials on how to use timers in c#. 
4. None of the tutorials i followed actually orked. Their code isnt working on my machine and i dont know why? Versions maybe?
5. I also tried implementing a 3rd option that prints out the reasources. But it only prints out the number of resource types and not the number of resources contained.
6. Hlp plox.

Wednesday 11/03/2020:
----------------------------
1. Pulled the last commit and reviewed.
2. Located all the pieces involved with the inventory.
3. Played around until i got more familiar.
4. I thought i had a plan but when i fired it up nothing happened. Nothing broke but nothing changed.
5. On Repl.cs : I tried using a double IF loop to set conditions for the CurrentOverlayState to trigger and print the Inventory text.
6. If that would have succeeded i would then advance to making it print CurrentOverlayState.Items
7. But try as i might i couldnt get it to work.   

SOME MORE TIME PASSED

Teusday 02/03/2020:
------------------------
1. Restored the daily report file.
2. Opened a new file for the overlay
3. Put down the groundwork for the overlay.
4. I think im in the right direction but im not there yet. Assistence required.
5. Factorio.mess has been fucked with. There is a bug now and my debugging came out empty. halp plox.

Sunday 16/02/2020:
-----------------------
1. Factorio late game is annoying but im getting the hang of it. Need to clear many bugs away from uranium ore so i can go nuclear.
2. Applied the fix you showed me to the code. Added another json file for the closet room.
3. I tried setting a condition on the "Search the closet" transition so it would only appear when item "Key" = 0. But it didnt work. I reverted it to avoid bugs.
4. Git push!
5. Its time i started digging into lambda multiplication.

Saturday 15/02/2020:
-------------------------
1. Spent all day with family.

Friday 14/02/2020:
---------------------
1. Factorio late game is a lot to take in.
2. More lambda practice.

Thursday 13/02/2020:
-------------------------
1. Relationships are hard. No code.
2. Practiced parsing lambda expressions. 

Wednesday 12/02/2020:
----------------------------
1. Visited master for a study session.

Teusday 11/02/2020:
------------------------
1. No code. Only death.


Monday 10/02/2020:
------------------------
1. Reviewed previous commits from master.
2. Attempted to edit json file "Hall". Now bug occurs. 
3. Attempting to understand new data structure. So far not much. Will need masters wisdom. 

Sunday 09/02/2020:
------------------------
1. I am become puddle. Spent the day collecting the shards of self.
2. Am ok now. Pressing forward.

Saturday 08/02/2020:
------------------------
1. A different friend in need

Friday 07/02/2020:
------------------------
1. A friend in need.

Thursday 06/02/2020:
------------------------
1. Death due to indigestion

Wednesday 05/02/2020:
------------------------
1. Visited master for a study session.

Teusday 04/02/2020:
------------------------
1. Death due to domestic dispute

Monday 03/02/2020:
------------------------
1. Death due to domestic dispute

Sunday 02/02/2020:
------------------------
1. FACTORIO IS WIFE!

Saturday 01/02/2020:
------------------------
1. FACTORIO IS LIFE!

Friday 31/01/2020:
------------------------
1. FACTORIO IS LOVE.

Thursday 30/01/2020:
------------------------
1. Got factorio

Wednesday 29/01/2020:
------------------------
1. Visited master for a study session.

Teusday 28/01/2020:
------------------------
SHITE!

Monday 27/01/2020:
------------------
1. Git pull to review masters bug fix.
2. Bug is indeed fixed. Cant really tell what changed in staterunner. How do i compare versions?
3. I would like to introduce a built in mechanic for revisited rooms. So that completed scenes will not repeat themselves. How is design?
4. Behold the code for my attempts.

Sunday 26/01/2020:
------------------
1. No code. I is not well in body.

Saturday 25/01/2020:
--------------------
1. No code today. Life is bitch.

Friday 24/01/2020:
------------------
1. Reviewed masters code.
2. Sent my previous failed merge to the git stash to be forgotten by the ages.
3. Sifted through my old projects for the Darkest Dark flavor and strucutre files.
4. Implemented into the data structure in the json files.
5. Encountered a number of bugs and some unpolished page layout issues.
	-= BUG: When approaching the iron gate without having the key. Choosing to LEAVE ROOM ends up opening the gate anyway. Could not trace back the reason.
6. GIT COMMIT -m + GIT PUSH!

Thursday 23/01/2020:
--------------------
1. No code today. I suck.

Wednesday 22/01/2020:
---------------------
1. Reviewed code and tried to improve stuff.
2. commit failed because i had to perform a pull first.
3. Visited master for a study session.

Teusday 21/01/2020:
-------------------
1. A bit of Udemy but not much else.

Monday 20/01/2020:
------------------
1. No code today. I suck.

Sunday 19/01/2020:
------------------
1. 5 more Udemy lessons.
2. reviewed my own code and tried to figure out a loop for the staterunner.
   I know im supposed to utilize the functions master ha built into the statrunner.cs but the specifics elud me.
3. Must grind my gears further! 

Saturday 18/01/2020:
--------------------
1. Reviewed masters code and teachings.
2. Updated data structure with a new field "Text".
3. Instanciated a stateRunner.
4. Updated Program.cs with some manual simulation of the app.
5. Need further abstraction now.  

Friday 17/01/2020:
------------------
1. Technical difficulties with updating code.

Thursday 16/01/2020:
--------------------
1. Busy day. No code.

Wednesday 15/01/2020:
---------------------
1. More udemy course lessons. Doing code excercises.
2. Visited master for a study session.

Teusday 14/01/2020:
-------------------
1. More udemy course lessons. Doing code excercises.
2. Added more states and transitions. Would like to learn how to make states with more than 2 options.
	I mean how to edit the json data conversion to include more arguments.
3. Attempted to make a StateRunner class. Failed after a number of attempts.
	Need further assistance.  

Monday: 13/01/2020:
-------------------
1. More udemy course lessons.
2. Some udemy course practice assignments. Solving simple problems with code.
3. reviewed yesterdays code. Man classes are crazy. And you said its a very simple exmaple... JESUS.
4. Played a bit with the data members to see that i truely got the idea. also i fixed the funny var name you placed instead of "transitions".

Sunday 12/01/2020:
------------------
1. Finished more udemy lessons. Halfway through beginners course.
2. worked with master on Darkest Dark class instantiation.
3. Brain is of dieded. But much prevail. Level up is imminent. 

Saturday 11/01/2020:
Did nothing. Ass broke.

Friday 10/01/2020:
------------------
Did nothing. time broke.

Thursday 09/01/2020:
--------------------
1. Finished another 5 lessons from udemy course.
2. Reviewed masters code.
3. Did some tinkering to no avail.
4. Cried to master. got advice.
5. Attempted to follow advise to no avail.
6. Will persist tomorrow.

Wednesday 08/01/2020:
---------------------
1. Finished another 5 lessons from udemy course.
2. Visited master for a study session.

Teusday 07/01/2020:
-------------------
1. Finished another 5 lessons from udemy course.
2. Added 3 classes to the DarkestDark project: State, Transition, StateRunner.
3. Encountered bug in StateRunner. Please review comments on code.
4. Data structure issues from yesterday still not addressed.

Monday 06/01/2020:
------------------
1. Finished 5 more lessons of C# undemy course.
2. Reviwed the state machine code and parsed the program tree.
	Encountered issues when comparing it with my code.
	1. Data structure on DarkestDark is still too primitive. Needs enhancement.
	2. Json translation not incorporated to original state machine process.

Have decided to rebuild data structure of darkest dark to fit the state machine flow + integrate json translation.
Will require assistance tomorrow when have brain power to deal with.

Sunday 05/01/2020:
------------------
1. Finished 5 1st lessons of C# udemy course.
2. Updated code with new class locations with its own json file.
3. Had an insightful meditation.
4. Overcame a panic attack during studying, then continued on to finish task by refocusing mind. 


Saturday 04/01/2020:
--------------------
Am piece of shit. Did not git at all. SHAME!

Friday 03/01/2020:
------------------
Was involved with family all day. Am piece of shit and did no code.

Thursday 02/01/2020:
--------------------
1. Practiced sorting algo's.
2. Purchased an online c# course from Udemy. I need structure learning. I will add it to my current studies.
3. I have spoken to my therapist about our conversation. He agrees with your insight and explained it to me in terms i could understand. Thank you for your wisdom and patience with me.


Day 4:
------
1. Did some ASCII art on Program.cs

2. Expanded on the current code with another iteration of "switch".

3. Reviwed State machine code from the examples of older lessons.

4. Added goto startment with label to Program.cs

5. Lets git.

Day 3:
------
SATURADAY. So today i am a piece of shit and am not doing anything.

Day 2:
------
0. I going to try and solve the issue from yesterday. the NETcore app thingy!

1. So iv contacted master and he guided me on how to uodate the NET core stuff. Then we set the project to fit a specific version.

2. Now shit works so i can move on.

3. Iv decided to start writing documentation.

4. So iv started an FRD from scratch.

5. Time to git...

Day 1:
-------
0. Visual stuio needed a big update. 

1. I erased the submodule i made of the git.wiki

2. I did git pull and got the Darkest dark project.

3. I edited some text scripts (Not code).

4. ERROR: Build didnt run.

5. Errorlog said i need to get Newtonsoft json reader to run build.

6. Google foo gave me instrusctions on how to get it through visual stuio interface.

7. Newtonsoft installed successfully.

8. try run build again. ERROR:  No compatible framework version available. log suggests:  installing Microsoft.NETCore.app, version 2.2.0

## Thats all iv got for tonight. but 1st commit is now official! :D 