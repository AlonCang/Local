﻿using DarkestDark.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkestDark.CLI
{
    public class Repl
    {
        public void Loop(StateRunner stateRunner, StateRunner overlayRunner)
        {
            overlayRunner.Items = stateRunner.Items;
            while (!stateRunner.IsGameOver)
            {
                foreach (var option in overlayRunner.GetCurrentTransitions())
                {
                    Console.WriteLine(overlayRunner.CurrentState.Text);
                    if (overlayRunner.CurrentState.Name == "Inventory")
                    {
                        var actualItems = stateRunner.Items.Where(kvp => kvp.Value != 0);
                        var itemsWithDescriptions = actualItems.Select(kvp => $"{kvp.Key}: {kvp.Value} - {stateRunner.Graph.States.GetValueOrDefault(kvp.Key, new State("", "")).Text}");
                        Console.WriteLine($"INVENTORY: \n {string.Join("\n ", itemsWithDescriptions)}");
                    }
                    else if (overlayRunner.CurrentState.Name == "Journal")
                    {
                        string journal = string.Join("\n ",
                            stateRunner.Items.Where(kvp => kvp.Key.StartsWith("@")).Select(kvp => kvp.Key.Substring(1)));
                        Console.WriteLine($"JOURNAL: \n{journal}");
                    }
                    Console.WriteLine(option);
                }
                Console.WriteLine(stateRunner.GetCurrentState());
                int i = 1;
                foreach (var option in stateRunner.GetCurrentTransitions())
                {
                    Console.WriteLine($"{i++} " + option);
                }
                Console.Write("> ");
                var choice = Console.ReadLine();
                if (choice == "quit")
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine($"> {choice}");
                var overlayChoice = overlayRunner.KeyToTransition(choice);
                if (choice != overlayChoice)
                {
                    overlayRunner.PerformTransition(overlayChoice);
                }
                else
                {
                    choice = stateRunner.IndexToTransition(choice);
                    string transitionResultText = stateRunner.PerformTransition(choice);
                    Console.WriteLine(transitionResultText);
                }
                Console.WriteLine(overlayRunner.Items.Count);

            }
        }
    }
}
