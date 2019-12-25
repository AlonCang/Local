using System;

namespace DarkestDark.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DARKEST DARK. NOW DIE! Kidding. You are infront of scary house. What do you do? \n 1. Knock on door \n 2.Break bitch door! IS MY HOUSE!" );
            var choice = Console.ReadLine();
            switch (choice)
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
                    break;
            }

            Console.WriteLine("Run Completed successfully");
        }
    }
}
