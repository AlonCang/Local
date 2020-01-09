using DarkestDark.Game;
using System;

namespace DarkestDark.CLI
{

    class Program
    {
        
        static void Main(string[] args)
        {
            StateGraph.LoadStateGraph(
                @"C:\Users\User\source\repos\Local\DarkestDark\DarkestDark.Game\States.json",
                @"C:\Users\User\source\repos\Local\DarkestDark\DarkestDark.Game\Transitions.json");

           
            
                      Console.WriteLine("==============================================================");
            Console.WriteLine("=======================-=DARKEST DARK=-======================= " +
            "\n==============================================================" +
            " \n You are a badass inquisitor standing before a dark mansion." +
            " \n It is your duty to vanquish whatever evil lurks inside!" +
            "\n What do you do? \n 1. Open the door carefully \n 2. Kick down the door!" );
            Console.WriteLine("==============================================================");
            var choice01 = Console.ReadLine();
                         
        }
    }
}
