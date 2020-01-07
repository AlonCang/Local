using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    public class Transition
    {
        public string Name;
        public string Text;
        public State Source;
        public State Target;

        public Transition(string name, string text, State source, State target)
        {
            Name = name;
            Text = text;
            Source = source;
            Target = target;
            Source.Options.Add(this);
        }

        public override string ToString()
        {
            return $"{Name} to {Target.Name}";
        }
    }
}
