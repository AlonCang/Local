using DarkestDark.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkestDark.CLI
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
                string transition = stateRunner.PerformTransition(choice);
                Console.WriteLine(transition);
            }
        }
    }
}
