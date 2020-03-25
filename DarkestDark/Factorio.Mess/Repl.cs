using DarkestDark.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorio.Mess
{
    public class Repl
    {
        public void Loop(StateRunner stateRunner)
        {
            while (!stateRunner.IsGameOver)
            {
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
                choice = stateRunner.IndexToTransition(choice);
                string transitionResultText = stateRunner.PerformTransition(choice);
                Console.WriteLine(transitionResultText);
            }
        }
    }
}
