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
        }

        public string GetCurrentState()
        {
            return "-------------------------------------------------------------------------\n" + $"[{CurrentState.Name} || INVENTORY: ({string.Join(", ", Items)})]\n" + "-------------------------------------------------------------------------\n" +
                $"{CurrentState.Text}\n" + "-------------------------------------------------------------------------";
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
            if (int.TryParse(transition, out int index) 
                && index > 0 
                && index <= CurrentState.Transitions.Count)
            {
                transition = GetCurrentTransitions()[index-1];
            }
            if (Graph.Transitions.ContainsKey(transition))
            {
                Transition tobj = Graph.Transitions[transition];
                var targetState = tobj.TargetName;
                CurrentState = Graph.States[targetState];
                if (tobj.Text == "quit")
                {
                    IsGameOver = true;
                    return "Game is now over... Bitch...";
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
    }
}

