DarkestDark.Game:

	Class Transition:
			
			A `string` called `Name`
			A `string` called `Text`
			A `Dictionary<string, int>` called `Conditions`
			A `Dictionary<string, int>` called `Items`
			A `string` called `TargetName`

			A Boolean called `IsLegal` which receives a `Dictionary<string, int>` called items
				
				if `Conditions` dictionary is not empty

					foreach element in `Conditions`

						Check if element does NOT contain this string `~` and assign the result to a boolean named `isNeg`
							
							if `isNeg` returns `true`

								a string variable called `key` is assigned the `string` value of the element without its `0` position character

									if `Items` dictionary does not contain the value assigned to `key`

										return `true`

										else return `The element in `items` dictionary which correspondes to the value saved in `key` is smaller than the value saved into the `Value` member of 
										the `kvp` of the corresponding element in the `Conditions` dictionary`


							else (`isNeg` returns `false` (element does contain the string `~`))
								
								Check if `items` dictionary does NOT contain the value assigned to the `Key` of the `kvp` element of the `Conditions` dictionary.
									
									return `false` if its not there

								else (its there) return the element in `items` dictionary at the position that correspondes with the value saved into the `Key` member
								of the `kvp` of the element in `Conditions` dictionary is greater or equal to the `Value` member of the same `kvp` element from `Conditions`
								dictionary


				else (conditions are empty) return `true`



			ToString()

				return a formatted string that contains: Name + Text + Items + TargetName






Lord have mercy those booleans are confusing. im not entirely sure why they are set up that way.
iv got gut feelings / hunches but i also dont really get it.

The `isNeg` boolean return matrix is weirding me out. I dont get it. What am i suppose to do with the info returned from the >= or the < operators?

Also how can the value of `cond.Key` which is a `string` be equal to the `cond.Value` which is an `int`? How is that legal? ARREST SOMEBODY! :P

										
									
									