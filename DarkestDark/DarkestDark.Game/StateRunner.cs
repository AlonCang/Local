using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

/// <summary>
/// Iv tried to make a stateRunner that would read the json files and combine
/// the "states" and "transitions" into 1 dictionary of states and transitions.
/// But after a number of tries i see i do not understand the machine well enough to pull this off.
///
/// then i tried other things but iv run out of brain power and im done fucking up.
/// Hopefully Tomorrow you can get this stuff through my skull.
/// </summary>

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

        public void PerformTransition(string tn)
        {
            var targetState = Graph.Transitions[tn].TargetName;
            CurrentState = Graph.States[targetState];
        }
    }
}

