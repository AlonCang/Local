using DarkestDark.Game;
using System;

namespace DarkestDark.CLI
{

    class Program
    {
        public static void Main(string[] args)
        {
            var stateGraph = StateGraph.LoadStateGraph(
                @"C:\Users\User\source\repos\Local\DarkestDark\DarkestDark.Game\States.json",
                @"C:\Users\User\source\repos\Local\DarkestDark\DarkestDark.Game\Transitions.json");

            foreach (var state in stateGraph.States.Values)
            {
                Console.WriteLine(state.Name);
                foreach (var tstr in state.Transitions)
                {
                    Console.WriteLine(" -> " + tstr + " : " + stateGraph.Transitions[tstr].TargetName);
                }
            }
        }
    }
}
