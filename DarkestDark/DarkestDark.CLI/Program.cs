using DarkestDark.Game;
using System;

namespace DarkestDark.CLI
{

    class Program
    {
        public static void Main(string[] args)
        {
            var stateGraph = StateGraph.LoadStateGraph(
                @"..\..\..\..\DarkestDark.Game\States.json",
                @"..\..\..\..\DarkestDark.Game\Transitions.json");

            // foreach (var state in stateGraph.States.Values)
            // {
            //     Console.WriteLine(state.Name);
            //     Console.WriteLine(state.Text);
            //     foreach (var transition in state.Transitions)
            //     {
            //        Console.WriteLine(" -> " + transition + " : " + stateGraph.Transitions[transition].TargetName);
            //     }
            // }





            // Instantiate a state runner and set its initial state. 
            var runner = new StateRunner(stateGraph, "Outside");

            // Print the state text data. Then print out the available options.
            Console.WriteLine(runner.CurrentState.Text);
            foreach (var transition in runner.CurrentState.Transitions)
            {
                Console.WriteLine("* " + stateGraph.Transitions[transition].Name);
            }
            // Save user input.
            var choice = Console.ReadLine();
            /* Master: Here is a little gift...*/
            // Execute method by input.
            var transitionText = runner.PerformTransition(choice);

            // Print the transition text data.
            Console.WriteLine(transitionText);

            // Print the state name and text. Then print the available options.
            Console.WriteLine(runner.CurrentState.Name + '\n' + runner.CurrentState.Text);
            foreach (var transition in runner.CurrentState.Transitions)
            {
                Console.WriteLine("* " + stateGraph.Transitions[transition].Name);
            }
            // There should be a clear console at some point, but thats just visual.
            // Also some numbers instead of having to write the transition name. Gotta look that up.
            // My focus should be on making a loop that contains all of the above and possibly more.
            // Should it be built here on program.cs? 
            /* Master: At this point it doesn't really matter where you write anything as long as you write it anywhere*/
            // Or should it be included in the StateRunner.cs?
            /* Master: write it where you can, if you find that you need some specific variables (instances) that exist in specific places, maybe put it closer there.*/
            // Or should it belong to a class of its own "GameRunner" or something. But that doesnt't sound right.
            /* Master: I would start by putting the correct part of main in a loop that breaks when the user types "exit" */
            /* Master: Also Making PerformTransition more robust <==> make it not crash for *bad* inputs */

        }
    }
}
