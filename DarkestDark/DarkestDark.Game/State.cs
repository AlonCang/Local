using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace DarkestDark.Game
{
    public class State
    {
        // I dont understand why is it that "trasition" is placed inside the <List>. 
        public string Name;
        public List<string> Transitions = new List<string>();

        public State(string name)
        {
            Name = name;
        }

        public override string ToString()
        {       
            return "{" + $"\"Name\": \"{Name}\", " +
                $"\"Transitions\": [ {string.Join(", ", Transitions.Select(t => $"\"{t}\""))} ]" + 
                "}";
        }
    }


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

            return null;
        }
    }
}
