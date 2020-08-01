2 dimentional grid
every single cell holds 1 thing
thing can be a creature

a grid called world:
	- coordinates of all occupied cells
	- Function calle tick: When world ticks, all creatures tick
	- world will send each creature its relevant data
	- creature will return what he is now doing
	
A creature can have stats:
	- Power
	- Vision (how far can creature see enemies and food)
	

A creature can perform actions: 
	- move
	- eat (power +1, can only eat creatures with less power than you)
		
	

Decision mechanism:
	- 