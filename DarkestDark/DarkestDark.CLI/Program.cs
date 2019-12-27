using System;

namespace DarkestDark.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=DARKEST DARK=- \n You are a badass inquisitor standing before a dark mansion. \n It is your duty to vanquish whatever evil lurks inside!" +
                "\n What do you do? \n 1. Open the door carefully \n 2.Kick down the door!" );
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
