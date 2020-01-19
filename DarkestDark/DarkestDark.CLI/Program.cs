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

          //  foreach (var state in stateGraph.States.Values)
          //  {
          //      Console.WriteLine(state.Name);
          //      Console.WriteLine(state.Text);
          //      foreach (var transition in state.Transitions)
          //      {
          //         Console.WriteLine(" -> " + transition + " : " + stateGraph.Transitions[transition].TargetName);
          //      }
          //  }


            
            

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

            // Execute method by input.
            runner.PerformTransition(choice);

            // Print the transition text data.
            Console.WriteLine("This is supposd to be the Text of the transition chosen by the user. But i suck.");

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
            // Or should it be included in the StateRunner.cs?
            // Or should it belong to a class of its own "GameRunner" or something. But that doesnt't sound right.
        }
    }
}
