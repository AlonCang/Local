using DarkestDark.Game;
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
                var printed = "";
                if (overlayRunner.CurrentState.Name == "Inventory")
                {
                    var actualItems = stateRunner.Items.Where(kvp => kvp.Value != 0);
                    var itemsWithDescriptions = actualItems.Select(kvp => $"{kvp.Key}: {kvp.Value} - {stateRunner.Graph.States.GetValueOrDefault(kvp.Key, new State("DefaultName", "DefaultText")).Text}");
                    var inventory = string.Join("\n ", itemsWithDescriptions);
                    Console.WriteLine($"INVENTORY: \n {inventory}");
                    printed = inventory;
                }
                else if (overlayRunner.CurrentState.Name == "Journal")
                {
                    var journalEntries = stateRunner.Items.Where(kvp => kvp.Key.StartsWith("@"));
                    string journal = string.Join("\n ",
                       journalEntries.Select(kvp => kvp.Key.Substring(1)));
                    Console.WriteLine($"JOURNAL: \n{journal}");
                    printed = journal;
                }
                Console.WriteLine(overlayRunner.CurrentState.Text);
                foreach (var option in overlayRunner.GetCurrentTransitions())
                {
                    if (!printed.Contains(option))
                    {
                        Console.WriteLine(option);
                    }
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
