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
        public State CurrentState;

        public StateRunner(State initialState)
        {
            CurrentState = initialState;
        }

        public static StateRunner DisplayCurrentState(string statesPath, string transitionsPath)
        {
            var statesJson = File.ReadAllText(statesPath);
            var states = JsonConvert.DeserializeObject<List<State>>(statesJson);
            var transitionsJson = File.ReadAllText(transitionsPath);
            var transitions = JsonConvert.DeserializeObject<List<Transition>>(transitionsJson);

            public Dictionary = new Dictionary<string states, string transitions>();

            foreach (var state in states)
            {
                result.States[state.Name] = state;
            }
            foreach (var transition in transitions)
            {
                result.Transitions[transition.Name] = transition;
            }
            return result;
        }
    }
}

