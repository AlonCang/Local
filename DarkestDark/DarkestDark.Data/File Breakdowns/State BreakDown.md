﻿DarkestDark.Game

	class State

		a string called Name
		a string called Text
		a list of strings called "Transitions"

		a `State` that receives a `string` called `name` and a `string` called `text`. They each get assigned to string variables.
		**This is called a Constructor, it is a function.**
		
		ToString()
			a string variable called result is assigned the value of a string which contains `Name` and `Text`

			foreach element in `Transitions`
				add the element into the string assigned to `result`
			
			remove 1 character from the end of the expression saved into `result`
			add a bit more string content to `result`
			return `result`
		**This method only exists so you have an example of how to go over all of the members and print them in some format.**
		**In reality this code is basically equivalent to `JsonConvert.Serialize(state)` for some instance `state`**




Im actually amazed by this piece of code.
Its so short yet... so potent.

Also the way ToString is used. It resolved so many problems without leaving any room for error.
I mean dont get me wrong it looks a bit messy but its just because its packed.