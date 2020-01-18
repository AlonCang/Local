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

            var runner = new StateRunner(stateGraph, "Outside");

            Console.WriteLine(runner.CurrentState.Text);
            foreach (var transition in runner.CurrentState.Transitions)
            {
                Console.WriteLine("* " + stateGraph.Transitions[transition].Name);
            }
            var choice = Console.ReadLine();

            runner.PerformTransition(choice);

            Console.WriteLine("This is supposd to be the Text of the transition chosen by the user. But i suck.");

            Console.WriteLine(runner.CurrentState.Name + '\n' + runner.CurrentState.Text);
            foreach (var transition in runner.CurrentState.Transitions)
            {
                Console.WriteLine("* " + stateGraph.Transitions[transition].Name);
            }
        }
    }
}
