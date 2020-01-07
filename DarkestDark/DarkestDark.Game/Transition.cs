using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    public class Transition
    {
        // These are the class fields
        public string Name;
        public string Text;
        public State Source;
        public State Target;

        // This is a class method that recieves arguments that match those fields and assigns them all to those fields.
        // It also adds these new saved values to Options file.
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
