using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new string[] { "A", "B", "C", "D", "X" };
            Console.WriteLine("Hello World!");
            RecursiveAllWords(letters);
        }

        private static void RecursiveAllWords(string[] letters, string soFar = "")
        {
            if (letters.Length == 0)
            {
                Console.WriteLine(soFar);
                return;
            }
            string[] etters = letters.Skip(1).ToArray();
            RecursiveAllWords(etters, soFar + letters[0]);
            RecursiveAllWords(etters, soFar);
        }

        private int Factorial(int n)
        {
            if (n == 1) { return 1; }
            return n * Factorial(n - 1);
        }
    }
}
