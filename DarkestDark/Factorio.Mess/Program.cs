using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;


namespace Factorio.Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration Statement:
            // <Type> <Name> = <ValueExpr>;
            // <Type> <Name>;
            int loopCounter = 0;
            Miner miner = new Miner();
            Builder builder = new Builder();
            var buildings = new Dictionary<string, List<Building>>();
            var resources = new Dictionary<Resource, int>();
            object a = new Coal();
            object b = new Coal();

            while (true)
            {

                loopCounter++;
                Console.WriteLine($"Loop Number: {loopCounter}");
                Console.WriteLine("This is mining simulator. Drill for resources or build a drill?\n" +
                    "1. Drill manually like bitch\n" +
                    "2. Build drill like boss \n" +
                    "3. View Resources");
                var c = Console.ReadLine();
                if (c == "2")
                {
                    Console.WriteLine("Would you like to build a coal or an iron drill?\n" +
                        "1. Coal drill \n" +
                        "2. Iron drill");
                    var c2 = Console.ReadLine();
                    Building result2;
                    if (c2 == "2")
                    {
                        result2 = builder.BuildIronDrill();
                    }
                    else
                    {
                        result2 = builder.BuildCoalDrill();
                    }
                    if (!buildings.ContainsKey(result2.Name))
                    {
                        buildings.Add(result2.Name, new List<Building>());
                    }
                    buildings[result2.Name].Add(result2);
                    Console.WriteLine($"You now have {buildings[result2.Name].Count} {result2.Name}");
                }
                else if (c == "1")
                {
                    var result = miner.MineCoal();
                    if (!resources.ContainsKey(result))
                    {
                        resources.Add(result, 0);
                    }
                    resources[result] ++;
                    Console.WriteLine($"You now have {resources[result]} {result.Name}");
                }
                else
                {
                    Console.WriteLine("You now have: \nResources: \n");
                    foreach (var resource in resources)
                    {
                        Console.WriteLine($"{resource.Key.Name}: {resource.Value}");
                    }
                    foreach (var building in buildings)
                    {
                        Console.WriteLine($"{building.Key}: {building.Value.Count}");
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
