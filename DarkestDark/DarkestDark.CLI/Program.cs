using DarkestDark.Game;
using System;
using System.Linq;

namespace DarkestDark.CLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            StateGraph stateGraph;
            StateRunner runner;
            if (args.Contains("Debug"))
            {
                stateGraph = StateGraph.LoadStateGraph(
                    @"..\..\..\..\DarkestDark.Game\MiniStates.json",
                    @"..\..\..\..\DarkestDark.Game\MiniTransitions.json");
                runner = new StateRunner(stateGraph, "Iron gate");
            }
            else
            {
                stateGraph = StateGraph.LoadStateGraph(
                    @"..\..\..\..\DarkestDark.Game\States.json",
                    @"..\..\..\..\DarkestDark.Game\Transitions.json");
                runner = new StateRunner(stateGraph, "Outside");
            }
            // Instantiate a state runner and set its initial state. 
            new Repl().Loop(runner);
        }
    }
}
