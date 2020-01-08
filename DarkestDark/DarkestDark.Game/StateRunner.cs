using System;
using System.Linq;
using System.Collections.Generic;

namespace DarkestDark.Game
{
    public class StateRunner
    {
        // this State class has a field called CurrentState.
        // It also has a dictionary called KeyBinds that recieves a character for its key and an int for its value.
        public State CurrentState;
        public Dictionary<char, int> KeyBinds = new Dictionary<char, int>();

        // This is a class method that recieves an initialState and turns it into the CurrentState
        public StateRunner(State initialState)
        {
            CurrentState = initialState;
        }

        // This is a class method returns the name of the current state.
        public string DisplayCurrentstate()
        {
            return CurrentState.Name;
        }

       
    }
}
