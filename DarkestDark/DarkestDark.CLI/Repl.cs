using DarkestDark.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.CLI
{
    public class Repl
    {
        public void Loop(StateRunner stateRunner, StateRunner overlayRunner)
        {
            while (!stateRunner.IsGameOver)
            {
                foreach (var option in overlayRunner.GetCurrentTransitions())
                {
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
            }
        }
    }
}
