using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using DarkestDark.Game;


namespace Factorio.Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipes = Recipe.LoadRecipes("../../../Recipes");
            foreach (var rec in recipes)
            {
                Console.WriteLine(rec.Name);
                Console.WriteLine("- Inputs:");
                foreach (var inp in rec.Input)
                {
                    Console.WriteLine($"  {inp.Key}: {inp.Value}");
                }
                Console.WriteLine("- Outputs:");
                foreach (var outp in rec.Output)
                {
                    Console.WriteLine($"  {outp.Key}: {outp.Value}");
                }                
            }
        }
    }
}
