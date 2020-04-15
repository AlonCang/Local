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
                    var inventory = "";
                    State defaultState = new State("DefaultName", "DefaultText");
                    foreach (var item in stateRunner.Items)
                    {
                        if (item.Value == 0)
                        {
                            continue;
                        }
                        var itemName = item.Key;
                        var itemamount = item.Value;
                        var itemText = stateRunner.Graph.States.GetValueOrDefault(itemName, defaultState).Text;
                        inventory += $" - {itemName}: {itemamount}| - {itemText} \n";

                    }
                    // Old code version. does pretty much the same as the foreach above it
                    // var actualItems = stateRunner.Items.Where(kvp => kvp.Value != 0);
                    // var itemsWithDescriptions = actualItems.Select<KeyValuePair<string, int>, string>(kvp => $"{kvp.Key}: {kvp.Value} - {stateRunner.Graph.States.GetValueOrDefault(kvp.Key, new State("DefaultName", "DefaultText")).Text}");
                    // var inventory = string.Join("\n ", itemsWithDescriptions);
                    Console.WriteLine($"INVENTORY: \n {inventory}");
                    printed = inventory;
                }
                else if (overlayRunner.CurrentState.Name == "Journal")
                {
                    var journal = "";
                    State defaultState = new State("DefaultName", "DefaultText");
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
                    // Old code version. does pretty much the same as the foreach above it
                    //var journalEntries = stateRunner.Items.Where(kvp => kvp.Key.StartsWith("@"));
                    //var x = journalEntries.Select(kvp => kvp.Key.Substring(1));
                    //var entriesWithDescriptions = journalEntries.Select(kvp => $"- {kvp.Key}: {stateRunner.Graph.States.GetValueOrDefault(kvp.Key, new State("DefaultName", "DefaultText")).Text}");
                    //string journal = string.Join("\n ", entriesWithDescriptions);
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
                Console.WriteLine(overlayRunner.Items.Count);

            }
        }
    }
}
// Select function definition:
//
// public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector);

// Select<TSource, TResult> : The function name, followed by its Generic / Template variables
