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
            State defaultState = new State("DefaultName", "DefaultText");
            overlayRunner.Items = stateRunner.Items;
            while (!stateRunner.IsGameOver)
            {
                var printed = "";
                if (overlayRunner.CurrentState.Name == "Inventory")
                {
                    var inventory = "";
                    foreach (var item in stateRunner.Items)
                    {
                        if (item.Value == 0)
                        {
                            continue;
                        }
                        var itemName = item.Key;
                        var itemText = stateRunner.Graph.States.GetValueOrDefault(itemName, defaultState).Text;
                        inventory += $" - {itemName}: {item.Value}| - {itemText} \n";
                    }
                    Console.WriteLine($"INVENTORY: \n {inventory}");
                    printed = inventory;
                }
                else if (overlayRunner.CurrentState.Name == "Journal")
                {
                    var journal = "";
                    foreach (var kvpEntry in stateRunner.Items)
                    {
                        if (!kvpEntry.Key.StartsWith("@"))
                        {
                            continue;
                        }
                        var journalKey = kvpEntry.Key.Substring(1);
                        var journalEntryText = stateRunner.Graph.States.GetValueOrDefault(journalKey, defaultState).Text;
                        journal += $" - {journalKey}: {journalEntryText} \n";
                    }
                    Console.WriteLine($"JOURNAL: \n {journal}");
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
            }
        }
    }
}
// Select function definition:
//
// public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector);

// Select<TSource, TResult> : The function name, followed by its Generic / Template variables
