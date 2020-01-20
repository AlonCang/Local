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

        public string PerformTransition(string transition)
        {
            Transition tobj = Graph.Transitions[transition];
            var targetState = tobj.TargetName;
            CurrentState = Graph.States[targetState];
            return tobj.Text;
        }
    }
}

