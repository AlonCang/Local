using DarkestDark.Game;
using System;

namespace DarkestDark.CLI
{

    class Program
    {
        static void Main(string[] args)
        {
            StateGraph.LoadStateGraph(
                @"D:\Projects\Students\Alon_Tsang\Local\DarkestDark\DarkestDark.Game\States.json",
                @"D:\Projects\Students\Alon_Tsang\Local\DarkestDark\DarkestDark.Game\Transitions.json");

        start1:;
            Console.WriteLine("==============================================================");
            Console.WriteLine("=======================-=DARKEST DARK=-======================= " +
                "\n==============================================================" +
                " \n You are a badass inquisitor standing before a dark mansion." +
                " \n It is your duty to vanquish whatever evil lurks inside!" +
                "\n What do you do? \n 1. Open the door carefully \n 2. Kick down the door!" );
            Console.WriteLine("==============================================================");
            var choice01 = Console.ReadLine();
            switch (choice01)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;              
                case "quit":
                    Console.WriteLine("Quit.");
                    return;
                default:
                    Console.WriteLine("Invalid input, please choose from available options.");
                    goto start1;
            }

            start2:;
            Console.WriteLine("You are now in a spooky entrance hall. There are 3 doors. What do you do?" +
                " \n 1. Go to the closet room." +
                " \n 2. Go to the kitchen. " +
                " \n 3. Go to the living room.");
            var choice02 = Console.ReadLine();
            switch (choice02)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                case "quit":
                    Console.WriteLine("Quit.");
                    return;
                default:
                    Console.WriteLine("Invalid input, please choose from available options.");
                    goto start2;                   
            }

            Console.WriteLine("Run Completed successfully");
        }
    }
}
