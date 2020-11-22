using Guilden.Common;
using System;
using System.Collections.Generic;

namespace Guilden.Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var kvp in GenerateItems(0, 30, -20, 40))
            {
                Console.WriteLine($"Item - {kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in GenerateAdventurers(0, 30, 20, 80))
            {
                Console.WriteLine($"Char - {kvp.Key}: {kvp.Value}");
            }

        }

        public static Dictionary<string, Stats> GenerateItems(int seed, int amount, int minValue, int maxValue)
        {
            var generator = new StringGenerator("Demo-Things", new[] { "eouo", "kptz", "mlsn" }, "10", "20", "102", "202");
            var result = new Dictionary<string, Stats>();
            var rng = new Random(seed);
            for (int i = 0; i < amount; i++)
            {
                var name = "The " + generator.GetName(2 + rng.Next(3));
                Stats stats = genStats(minValue, maxValue, rng);
                result[name] = stats;
            }
            return result;
        }

        public static Dictionary<string, Stats> GenerateAdventurers(int seed, int amount, int minValue, int maxValue)
        {
            var generator = new StringGenerator("Demo-Chars", new[] { "aeiuo", "myptsr", "cbpmlsn" }, "101", "10", "20", "102", "202");
            var result = new Dictionary<string, Stats>();
            var rng = new Random(seed);
            for (int i = 0; i < amount; i++)
            {
                var name = generator.GetName(1 + rng.Next(2)) + " " + generator.GetName(2 + rng.Next(3));
                Stats stats = genStats(minValue, maxValue, rng);
                result[name] = stats;
            }
            return result;
        }

        private static Stats genStats(int minValue, int maxValue, Random rng) => new Stats
        {
            Life = rng.Next(minValue, maxValue),
            Damage = rng.Next(minValue, maxValue),
            Support = rng.Next(minValue, maxValue),
            Utility = rng.Next(minValue, maxValue)
        };
    }
}
