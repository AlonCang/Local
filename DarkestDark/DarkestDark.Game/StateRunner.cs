using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;



namespace DarkestDark.Game
{
    public class StateRunner
    {
        public StateGraph Graph;
        public State CurrentState;
        public bool IsGameOver;
        public Dictionary<string, int> Items;

        public StateRunner(StateGraph graph, string initial)
        {
            Graph = graph;
            CurrentState = graph.States[initial];
            Items = new Dictionary<string, int>();
            Items.Add(initial, 0);
        }

        public string GetCurrentState()
        {
            return "-------------------------------------------------------------------------\n" + 
                $"[{CurrentState.Name}] ||\n" + 
                "-------------------------------------------------------------------------\n" +
                $"{CurrentState.Text}\n" + 
                "-------------------------------------------------------------------------";
        }

        public List<string> GetCurrentTransitions()
        {
            var result = new List<string>();
            foreach (var transition in CurrentState.Transitions)
            {
                if (Graph.Transitions[transition].IsLegal(Items))
                {
                    result.Add(transition);
                }
            }
            return result;
        }

        public string PerformTransition(string transition)
        {            
            if (Graph.Transitions.ContainsKey(transition))
            {
                Transition tobj = Graph.Transitions[transition];
                if (tobj.Text == "quit")
                {
                    IsGameOver = true;
                    return "Game is now over.";
                }
                var targetState = tobj.TargetName;
                CurrentState = Graph.States[targetState];
                if (!Items.ContainsKey(targetState))
                {
                    Items.Add(targetState, 0);
                }


                if (tobj.Items != null)
                {
                    foreach (var item in tobj.Items)
                    {
                        if (!Items.ContainsKey(item.Key))
                        {
                            Items[item.Key] = 0;
                        }
                        Items[item.Key] += item.Value;
                    }
                }
                return tobj.Text;
            }
            return "Bad input. Try again";
        }

        public string IndexToTransition(string indexString)
        {
            var legalTransitions = GetCurrentTransitions();
            if (int.TryParse(indexString, out int index)
                            && index > 0 && index <= legalTransitions.Count)
            {
                return legalTransitions[index - 1];
            }
            return indexString;
        }

        public string KeyToTransition(string keyString)
        {
            var legalTransitions = GetCurrentTransitions();
            foreach (var transition in legalTransitions)
            {
                if (transition.Contains($"'{keyString.ToUpper()}'"))
                {
                    return transition;
                }
            }
            return keyString;
        }

        public string BuildInventory()
        {
            State defaultState = new State("DefaultName", "DefaultText");
            var inventory = "";
            foreach (var item in Items)
            {
                if (item.Value == 0)
                {
                    continue;
                }
                var itemName = item.Key;
                var itemText = Graph.States.GetValueOrDefault(itemName, defaultState).Text;
                inventory += $" - {itemName}: {item.Value}| - {itemText} \n";
            }
            return inventory;
        }
    }
}

