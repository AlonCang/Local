﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;

namespace DarkestDark.Game
{
    public class State
    {
        public string Name;
        public string Text;
        public List<string> Transitions = new List<string>();

        public State(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            var result = "{" + $"\"Name\": \"{Name}\", ";
            result += " " + $"\"Text\": \"{Text}\", ";
            result += "\"Transitions\": [";
            foreach (var t in Transitions)
            {
                result += $" \"{t}\",";
            }
            result = result.Substring(0, result.Length - 1);
            result += " ] }";
            return result;
        }
    }
}
