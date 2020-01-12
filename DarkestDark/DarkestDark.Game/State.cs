using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;

namespace DarkestDark.Game
{
    public class State
    {
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
}
