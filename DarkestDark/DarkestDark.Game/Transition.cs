using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    /// <summary>
    /// Transition represents Edges of the State Graph.
    /// </summary>
    public class Transition 
    {        
        public string Name;
        public string Text;
        public string TargetName;

        public Transition(string name, string text, string targetName)
        {
            Name = name;
            Text = text;
            TargetName = targetName;            
        }

        public override string ToString()
        {
            return "{" + $"\"Name\": \"{Name}\", \"Text\": \"{Text}\", \"TargetName\": \"{TargetName}\"" + "}";
        }
    }
}
