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

        public StateRunner(StateGraph graph, string initial)
        {
            Graph = graph;
            CurrentState = graph.States[initial];
        }

        public string GetCurrentState()
        {
            return $"[{CurrentState.Name}]\n" +
                $"{CurrentState.Text}";
        }

        public List<string> GetCurrentTransitions()
        {
            return CurrentState.Transitions;
        }

        public string PerformTransition(string transition)
        {
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
                return tobj.Text;
            }
            return "Bad input. Try again";
        }
    }
}

