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
        public List<string> Items;

        public StateRunner(StateGraph graph, string initial)
        {
            Graph = graph;
            CurrentState = graph.States[initial];
            Items = new List<string>();
        }

        public string GetCurrentState()
        {
            return $"[{CurrentState.Name} with ({string.Join(", ", Items)})]\n" +
                $"{CurrentState.Text}";
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
                transition = CurrentState.Transitions[index-1];
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
                    Items.AddRange(tobj.Items);
                    Items = Items.Distinct().ToList();
                }
                return tobj.Text;
            }
            return "Bad input. Try again";
        }
    }
}

