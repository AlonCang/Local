﻿using DarkestDark.Game;
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
                    @"..\..\..\..\DarkestDark.Data\Mini\States",
                    @"..\..\..\..\DarkestDark.Data\Mini\Transitions");
                runner = new StateRunner(stateGraph, "A");
            }
            else
            {
                stateGraph = StateGraph.LoadStateGraph(
                    @"..\..\..\..\DarkestDark.Data\DarkestDark\States",
                    @"..\..\..\..\DarkestDark.Data\DarkestDark\Transitions");
                runner = new StateRunner(stateGraph, "Outside");
            }
            // Instantiate a state runner and set its initial state. 
            new Repl().Loop(runner);
        }
    }
}
