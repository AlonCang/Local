using System;

namespace Alons_Compiler
{
    // For now the program doesnt actually run a test. I just placed some basic code.
    // Not sure hwo to set up the rest.

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
