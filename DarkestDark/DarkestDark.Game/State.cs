using System.Collections.Generic;

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
    }
}
