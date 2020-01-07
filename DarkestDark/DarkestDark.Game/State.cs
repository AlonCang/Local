using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.Game
{
    public class State
    {
        // I dont understand why is it that "trasition" is placed inside the <List>. 
        public string Name;
        public List<Transition> Options = new List<Transition>();

        public State(string name)
        {
            Name = name;
        }
    }
}
