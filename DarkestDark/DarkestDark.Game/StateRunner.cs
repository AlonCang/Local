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


        /* 
         This is a class method that returns the options of the current state.
         there is a bug though with the type conversion.
        I dont understand at all what the .Select and .Aggregate lines do. NEED HELP!!! 
        Also i have no idea what Obsolete thingy is for.
        */
        [Obsolete]
        public string DisplayOptions()
        {
            return CurrentState.Options;
            .Select((Opt, i) => $"{i}. {Opt.Name}")
            .Aggregate("", (accumulator, item) => $"{accumulator}\n{item}");
        }


        /*
        This is a class method called Transition that recieves an int called option.
        It tries to turn the the current state target into the recieved value of the current state option.
        Then it returns the adventure option text.
        If there is an exception then it "catches" it and returns null instead. This prevents crashes i think.
        If i understand it correctly then it turns the recieved options into the options of the current state when transitioned into
        the next current state.
        Then it returns the text of those new options.
        */
        public string Transition(int option)
        {
            try
            {
                Transition adventureOption = CurrentState.Options[option];
                CurrentState = adventureOption.Target;
                return adventureOption.Text;            
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return null;
            }
        }
    }
}
