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

        public static List<string> LoadTestData(StateGraph graph)
        {
            // Collects the data relevant for the test.
            // Maybe 2 lists are required. Not sure.
            // I guess it could be incoporated seperately in each test.
            // so i thought of making it a function in itself instead of repeating.
            // Maybe this function is not required since i can access the data through the graph. IDK!
        }
        public Dictionary<string, int> TestForTargetStates(StateGraph graph)
        {
            // Will apply the data collected by LoadTestData().
            // Then return a list of items that idnt pass the test.
        }

        public Dictionary<string, int> TestForTransitions(StateGraph graph)
        {
            // Will apply the data collected by LoadTestData().
            // Then return a list of items that idnt pass the test.
        }

        public static List<string> PrintTestResults(Dictionary<string, int> TestResults)
        {
            foreach (var item in TestResults)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }


    }
}
