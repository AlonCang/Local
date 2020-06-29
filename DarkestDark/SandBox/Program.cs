using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string stateChoice = "state";
            string stateName;
            string stateText;
            string stateTransitions; // Will be turned into an int later via tryparse
            string transitionChoice = "transition";

            Console.WriteLine("Would you like to make a new State or a new Transition?");
            string userChoice = Console.ReadLine();
            if (userChoice == stateChoice)
            {
                Console.WriteLine("Please name the new state");
                stateName = Console.ReadLine();

                Console.WriteLine("Please enter state text");
                stateText = Console.ReadLine();

                Console.WriteLine("How many transitions?");
                string stateStringTransitions = Console.ReadLine();

                foreach (var transition in stateTransitions)
                {
                    // LABEL: Transition
                    Console.WriteLine("Please name transition");
                    string TransitionName = Console.ReadLine();

                    Console.WriteLine("Please enter transition text");
                    string transitionText = Console.ReadLine();

                    Console.WriteLine("How many conditions?");
                    string transitionConditions = Console.ReadLine(); // Will be turned into an int later via tryparse

                    foreach (var condition in transitionConditions)
                    {
                        Console.WriteLine("Please name condition");
                        string conditionName = Console.ReadLine();

                        Console.WriteLine("Please name condition number value");
                        string conditionValue = Console.ReadLine();

                    }
                        
                    Console.WriteLine("How many items does this transition contain?");
                    string transitionItems = Console.ReadLine(); // Will be turned into an int later via tryparse

                    foreach (var item in transitionItems)
                    {
                        Console.WriteLine("Please name item");
                        string itemName = Console.ReadLine();

                        Console.WriteLine("Is item an inventory item or a journal entry?");
                        string itemType = Console.ReadLine();

                        Console.WriteLine("Please enter item text");
                        string itemDescription = Console.ReadLine();
                    }

                    Console.WriteLine("Please enter target state");
                    string targetState = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("To which State would you like to add this transition?");
                string originalState = Console.ReadLine();

                // Search for the state in the data files
                // Save state path
                // goto Transition
            }

            // Generate Data: All that shit needs to be now be generated in a way that fits the data structure.
        }

    }
}
