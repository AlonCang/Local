using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;



namespace DarkestDark.Game
{
    public class StateRunner
    {
        public StateGraph Graph;
        public State CurrentState;

        public StateRunner(StateGraph graph, string initial)
        {
            Graph = graph;
            CurrentState = graph.States[initial];
        }

        public string GetCurrentState()
        {
            return CurrentState.Name;
        }

        public List<string> GetCurrentTransitions()
        {
            return CurrentState.Transitions;
        }

        public void PerformTransition(string transition)
        {
            var targetState = Graph.Transitions[transition].TargetName;
            CurrentState = Graph.States[targetState];
        }
    }
}

