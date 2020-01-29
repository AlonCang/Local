using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace DarkestDark.Game
{
    public class StateGraph
    {
        public Dictionary<string, State> States = new Dictionary<string, State>();
        public Dictionary<string, Transition> Transitions = new Dictionary<string, Transition>();

        private void AddStates(string statesPath)
        {
            var statesJson = File.ReadAllText(statesPath);
            var states = JsonConvert.DeserializeObject<List<State>>(statesJson);
            foreach (var state in states)
            {
                States[state.Name] = state;
            }

        }
        private void AddTransitions(string transitionsPath)
        {
            var transitionsJson = File.ReadAllText(transitionsPath);
            var transitions = JsonConvert.DeserializeObject<List<Transition>>(transitionsJson);
            foreach (var transition in transitions)
            {
                Transitions[transition.Name] = transition;
            }
        }

        public static StateGraph LoadStateGraph(string statesDirPath, string transitionsDirPath)
        {
            StateGraph result = new StateGraph();
            var statePaths = Directory.EnumerateFiles(statesDirPath, "*.json", SearchOption.AllDirectories);
            foreach (var statePath in statePaths)
            {
                result.AddStates(statePath);
            }

            var transitionPaths = Directory.EnumerateFiles(transitionsDirPath, "*.json", SearchOption.AllDirectories);
            foreach (var transitionPath in transitionPaths)
            {
                result.AddTransitions(transitionPath);
            }
            return result;
        }
    }
}
