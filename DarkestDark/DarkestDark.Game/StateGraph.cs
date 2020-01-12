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

        public static StateGraph LoadStateGraph(string statesPath, string transitionsPath)
        {
            var statesJson = File.ReadAllText(statesPath);
            var states = JsonConvert.DeserializeObject<List<State>>(statesJson);
            var transitionsJson = File.ReadAllText(transitionsPath);
            var transitions = JsonConvert.DeserializeObject<List<Transition>>(transitionsJson);
            StateGraph result = new StateGraph();
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
