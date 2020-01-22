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

            // Instantiate a state runner and set its initial state. 
            var runner = new StateRunner(stateGraph, "Outside");
            new Repl().Loop(runner);
        }
    }
}
