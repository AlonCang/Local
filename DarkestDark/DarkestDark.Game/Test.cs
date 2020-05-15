using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    class Test
    {
        public StateGraph Graph;
        public Dictionary<string, int> TestResults;

        public Test(StateGraph graph)
        {
            Graph = graph;
            TestResults = new Dictionary<string, int>();
        }

        public Dictionary<string, int> TestForTargetStates(StateGraph graph)
        {
            // Will apply the data collected by LoadTestData().
            // Then return a list of items that idnt pass the test.
            return null;
        }

        public Dictionary<string, int> TestForTransitions(StateGraph graph)
        {
            // Will apply the data collected by LoadTestData().
            // Then return a list of items that idnt pass the test.
            return null;
        }

        public static List<string> PrintTestResults(Dictionary<string, int> TestResults)
        {
            foreach (var item in TestResults)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            return null;
        }
    }


    //public class TestRunner
    //{
    //    public static void Main()
    //    {
    //        // Write the execution of the test code here ....
    //        var stateGraph = StateGraph.LoadStateGraph(
    //            @"..\..\..\..\DarkestDark.Data\Mini\States",
    //            @"..\..\..\..\DarkestDark.Data\Mini\Transitions");

    //        var test = new Test(stateGraph);

    //        var testTargetStates = (StateGraph graph) => 
    //        { 
    //            // for each transition target, make sure it is a state.
    //            foreach(var item in graph.Transitions)
    //            {

    //            }
    //        }
    //    }
    //}
}
