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
            StateRunner overlayRunner;
            if (args.Contains("Debug"))
            {
                stateGraph = StateGraph.LoadStateGraph(
                    @"..\..\..\..\DarkestDark.Data\Mini\States",
                    @"..\..\..\..\DarkestDark.Data\Mini\Transitions");
                runner = new StateRunner(stateGraph, "A");
            }
            else
            {
                stateGraph = StateGraph.LoadStateGraph(
                    @"..\..\..\..\DarkestDark.Data\DarkestDark\States",
                    @"..\..\..\..\DarkestDark.Data\DarkestDark\Transitions");
                runner = new StateRunner(stateGraph, "Main Menu");
                overlayRunner = new StateRunner(stateGraph, "Nothing");
            }
            // Instantiate a state runner and set its initial state. 
            new Repl().Loop(runner);

            // Overlay plan.
            // So iv reviewed the previous overlay that you have made sensei.
            // Since the previous project was structured differently i know i cant just copy paste it.
            // Ill try and use the current structure to implement it.
            // I started with doing what i could. Will need help ironing this out.

            new Repl().Loop(overlayRunner);
        }
    }
}
