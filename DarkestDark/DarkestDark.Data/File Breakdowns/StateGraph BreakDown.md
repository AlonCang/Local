DarkestDark.Game

	Class StateGraph

		A `Dictionary<string, State>` called States
		A `Dictionary<string, Transition>` called Transitions

		Function AddStates receives a string that leads it to a file called `statesPath`

			A string called `statesJson` is assigned the value returned from ReadAllText when given the `statesPath` string
			A list called `states` is assigned the value returned from JsonConvert.DeserializaObject when given a list of states that contains the string `statesJson`

			foreach element in `states`
				
				the name of that state is assigned to that element



		Function AddTransitions receives a string that leads it to a file called `transitionsPath`
		
			A string called `transitionsJson` is assigned the value returned from ReadAllText when given the `transitionsPath` string
			A string called `transitions` is assigned the value returned from JsonConvert.DeserializaObject when given a list of transitions that contains the string `transitionsJson`
			
			foreach element in `transitions`

				the name of that transition is assigned to that element



		Static function LoadStateGraph receives a string called `statesDirPath` and a string called `transitionsDirPath`

			A StateGraph called `result`
			An Enumerable list of strings called `statePaths` is assigned the value returned from Directory.EnumerateFiles when given `statesDirPath` (the paths to all .json files)

			foreach element in `statesPath`

				Perform AddStates on `result` with element as arg


			An Enumerable list of strings called `transitionPaths` is assigned the value returned from Directory.EnumerateFiles when given `transitionsDirPath` (the paths to all .json files) 

			foreach element in `transitionPaths`

				Perform AddTransitions on `result` ith element as arg

			return `result`




I think i get it. Sort of. Its all just boxes with sockets in boxes with sockets that keep trading their contents down a production line that uses
boxes with sockets from other places in the factory.

in macro its easy to simplify and explain.
in micro its causing my brain to bleed over the specifics that end up running smoothly like a swiss watch.
Humbling to say the least.