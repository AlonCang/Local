using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class GraphEditor
    {
        EditorStateGraph editorGraph = new EditorStateGraph();
        // Will i need to copy the whole stategraph code? Or can i connect to it by connecting project files?


        public static EditorStateGraph LoadStateGraph(string statesDirPath, string transitionsDirPath)
        {
            // Generates an empty stategraph by default.
            // OR
            // Generates a stategraph if given a path to a data bank. 
        }
        public static void CreateNewState()
        {
            // Receives: Name, Text, List of transitions, tree node ID (This will require adding a field that currently doesnt exist in the stategraph)
            // Checks for state name duplicates on current graph
            // if (state name is already taken)
            //      Send error prompt + ask for new state name
            // else
            //     Generate empty node and populate it with the new state.
            //     This could mean writing into an existing file or generating a new file and writing into it
        }

        public static void CreateNewTransition()
        {
            // Receives: Name, Text, Conditions, Items, TargetName, tree node ID, HostStateName
            // Checks for transition name duplicates on current graph
            // if (transition name already taken)
            //      Send error prompt + ask for new transition name
            // else
            //      Locate HostStateName + add new transition to its list of transitions

        }

        public static void PrintStateData()
        {
            // Receives: State Name
            // Searches for name in graph
            // Prints state raw data
        }

        public static void PrintTransitionData()
        {
            // Receives: Transition Name
            // Searches for name in graph
            // Prints transition raw data
        }

        public static void EditExistingState()
        {
            // Receives: State Name, new state
            // Finds state in graph
            // overwrites state with new state
            
        }

        public static void EditExistingTransition()
        {
            // Receives: transition Name, new transition
            // Finds transition in graph
            // overwrites transition with new transition
        }
    }
}
