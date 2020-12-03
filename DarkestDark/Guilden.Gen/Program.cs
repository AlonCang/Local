using Guilden.Common;
using Guilden.Common.Stuff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Guilden.Gen
{
    class Program
    {
        static void Main(string[] args)            
        {
            var assets = new AssetLibrary
            {
                Items = GenerateItems(0, 30, -20, 40),
                Chars = GenerateAdventurers(0, 30, 20, 80),
                Quests = GenerateQuests(0, 30, 0, 100, 100),
            };
            Console.WriteLine(JsonConvert.SerializeObject(assets));
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

        public static Dictionary<string, Quest> GenerateQuests(int seed, int amount, int minValue, int maxValue, int gold)
        {
            var result = new Dictionary<string, Quest>();
            var rng = new Random(seed);
            for (int i = 0; i < amount; i++)
            {
                var name = $"Quest{i}";
                Stats stats = genStats(minValue, maxValue, rng);
                StatRange itemRange = new StatRange
                {
                    Base = genStats(minValue, maxValue, rng),
                    Range = genStats(minValue, maxValue, rng),
                };
                StatRange charRange = new StatRange
                {
                    Base = genStats(minValue, maxValue, rng),
                    Range = genStats(minValue, maxValue, rng),
                };
                Quest quest = genQuest(stats, itemRange, charRange, gold, rng);
                result[name] = quest;
            }
            return result;
        }


        private static Quest genQuest(Stats stats, StatRange items, StatRange chars, int gold, Random rng) => new Quest
        {
            Stats = stats,
            GoldReward = rng.Next(gold),
            CharRewardRange = chars,
            ItemRewardRange = items,
        };
        private static Stats genStats(int minValue, int maxValue, Random rng) => new Stats
        {
            Life = rng.Next(minValue, maxValue),
            Damage = rng.Next(minValue, maxValue),
            Support = rng.Next(minValue, maxValue),
            Utility = rng.Next(minValue, maxValue)
        };
    }
}
