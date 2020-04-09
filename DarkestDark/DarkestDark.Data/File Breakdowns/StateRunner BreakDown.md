DarkestDark.Game:

	Class StateRunner:

		A StateGraph called `Graph`
		A State called `CurrentState`
		A Bollean called `IsGameOver`
		A `Dictionary<string, int>` called `Items`

		A constructor for StateRunner that receives a stategraph called `graph` and a string called `initial`
		
			The StateGraph `Graph` receives The value of `graph`
			The CurrentState assignes the value of `initial` into the States dictionary of the StateGraph called `graph`
			`Items` is a new `Dictionary<string, int>`
			Add the value of `initial` into the `Items` dictionary at `Value` 0



		A string GetCurrentState:

			return a formatted string that contains the `Name` + `Text` of the CurrentState



		A `List<string>` called `GetCurrentTransitions`:

			a `List<string>` called `result`
				
				foreach element in the list of current transitions:

					Check is the element returns as LEGAL

						if `true`

							Add the element to the list called `result`

						if `false`

							return the list `result` as is



		A PerformTransition receives a string called `transition`:

			if the `Transitions` dictionary of `Graph` contains `transition`

				A Transition called `tobj` receives the value of THAT `transition`
				A string variable called `targetState` receives the value of `tobg`s `TargetState`
				CurrentState receives the value of `targetState`

				if the value of `tobj`s `Text` is `quit`

					IsGameOver is now `true`
					return a `Game Over` string


				if `tobj`s items dictionary is NOT empty (does the transition contain items?)

					foreach element in items dictionary 
					
						Check if the `Key` member of the `kvp` does NOT exist (items dictionary does NOT have this item?)

							if `true` (we do not have this item)
								
								Assign the value 0 to elements `Key`

							if `false` (items dictionary DOES have this item)

								the elements `Value` is added to the elements `Key`


				if `tobj`s items dictionary IS empty

					return `tobj`s text (the transitions text)


			If `Graph` does not contain `transition`

				return string `Bad input`



		An IndexToTransition receives a string called `indexString`:

			A list of strings called `legalTransitions` is assigned the value returned from GetCurrentTransitions
			
				if the converted value of the string `indexString` which is now saved as an int called `index`, is greater than `0`
				AND is smaller than the number of elements in the `legalTransitions` list. (input cant be a number greater or smaller than the number of current transitions)

					return the element of `legalTransitions` list at the position the corresponds ith the value of `index` - `1` (to correctly read the data from the current structure)

				if the conversion fails (ilegal number input)

					return `indesString` as is



		A KeyToTransition receives a string called `keyString`:

			A list called `legalTransitions` is assigned the value returned from GetCurrentTransitions

				foreach element in `legalTransitions`

					if element contains the string `keyString` when capitalized

						return that element (a string of its name)

					if element does not contain `keyString` then return `keyString` as is
								

			
