using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;


namespace Factorio.Mess
{
    public class Builder
    {
        public Building BuildCoalDrill()
        {
            return new CoalDrill();
        }

        public Building BuildIronDrill()
        {
            return new IronDrill();
        }
    }
    public class Miner
    {
        public Resource MineCoal()
        {
            return new Coal();
        }

        public Resource MineIron()
        {
            return new Iron();
        }
    }
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

    public abstract class NamedKey
    {
        public string Name;
        public NamedKey(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is NamedKey nk)
            {
                return Name.Equals(nk.Name);
            }
            return false;
        }
    }


    public abstract class Resource : NamedKey
    {
        public Resource(string name) : base(name) { }
    }

    public class Coal : Resource
    {
        public Coal() : base(nameof(Coal)) { }
    }

    public class Iron : Resource
    {
        public Iron() : base(nameof(Iron)) { }
    }

    public abstract class Building : NamedKey
    {
        public DateTime BuildTime;

        public Building(string name) : base(name)
        {
            BuildTime = DateTime.Now;
        }
    }

    public class CoalDrill : Building
    {
        public CoalDrill() : base("Coal Drill") { }

        public Coal Mine()
        {
            return new Coal();
        }

        public int TotalMined()
        {
            var now = DateTime.Now;
            var timePassed = now - BuildTime;
            return (int)timePassed.TotalSeconds;
        }

        // HW: Implement a function that returns the amount mined since the last time the function was called.
        // Take into account the first time the func is called (what should happen then?)
        //public int MinedSoFar()
        //{
        //}
    }

    public class IronDrill : Building
    {
        public IronDrill() : base("Iron Drill") { }

        public Iron Mine()
        {
            return new Iron();
        }
    }
}
