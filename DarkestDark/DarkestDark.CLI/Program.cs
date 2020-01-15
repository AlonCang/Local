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

            foreach (var state in stateGraph.States.Values)
            {
                Console.WriteLine(state.Name);
                foreach (var transition in state.Transitions)
                {
                    Console.WriteLine(" -> " + transition + " : " + stateGraph.Transitions[transition].TargetName);
                }
            }
        }
    }
}
