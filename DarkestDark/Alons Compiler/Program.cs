using System;

namespace Alons_Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Compiler testing in motion. \nPlease enter a legal input to test the compiler \n>");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("This is bad input. Try again.");
                }
                else
                {
                    
                    Console.WriteLine($"This is your input: {input}");
                }

            }
        }
    }
}
