--------
Problems:
--------
1. If you exit a scene branch you cannot return to where you left off.
   You have to start back at the beginning of the branch.

2. When those branches have many transitions with many items & conditions
   it becomes too complex and time consuming during data placement.

3. Using the door renaming mechanism in order to make some options no longer
   available after having visited them. Is just a lot of busy work.

   Exmaple:
   StateName: InfoStand
   Text: A person has info. What do you ask?
   1. ask about x
   2. Ask about y
   3. Ask about z

   Each option enters a loop with a number of transitions that ends back 
   at the 1st conversation state. This time however the transitions that 
   have already been explored should no longer be available.


I have an IDEA!
What if we make a new subclass called: "ConversationState".

This one could behave differently than the regular states which are
used for room navigation. In these ConvStates transitions that lead to
states that have already been visited are no longer available as a 
default. With a possible string marker that makes an exception for 
unique transitions that should always be available or when a condition
is satisfied.


While were at it we can make a "CombatState" subclass so i wont have to
make each individual fight manually from top to bottom. But this is very
superfluous. I guess it would lead to a good old "Battle transition"
where combat is its own instance. But im getting ahead of myself. 

