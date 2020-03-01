using System;
using System.Collections.Generic;

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
            Miner miner = new Miner();
            Builder builder = new Builder();
            var buildings = new Dictionary<Building, int>();
            var resources = new Dictionary<Resource, int>();

            while (true)
            {
                Console.WriteLine("This is mining simulator. Drill for resources or build a drill?\n" +
                    "1. Drill manually like bitch\n" +
                    "2. Build drill like boss");
                var c = Console.ReadLine();
                if (c == "2")
                {
                    Console.WriteLine("Would you like to build a coal or an iron drill?\n" +
                        "1. Coal drill \n" +
                        "2. Iron drill");
                    var c2 = Console.ReadLine();
                    if (c2 == "2")
                    {
                        var result2 = builder.BuildIronDrill();
                        if (!buildings.ContainsKey(result2))
                        {
                            buildings.Add(result2, 0);
                        }
                        buildings[result2]++;
                        Console.WriteLine($"You now have {buildings[result2]} {result2.Name}");
                    }
                    else
                    {
                        var result2 = builder.BuildCoalDrill();
                        if (!buildings.ContainsKey(result2))
                        {
                            buildings.Add(result2, 0);
                        }
                        Console.WriteLine($"You no have {buildings[result2]} {result2.Name}");
                    }
                }
                else
                {
                    var result = miner.MineCoal();
                    if (!resources.ContainsKey(result))
                    {
                        resources.Add(result, 0);
                    }
                    resources[result]++;
                    Console.WriteLine($"You now have {resources[result]} {result.Name}");
                }
            }
        }
    }

    public abstract class Resource
    {
        public string Name;
        public Resource(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Resource res)
            {
                return Name.Equals(res.Name);
            }
            return false;
        }
    }

    public class Coal : Resource
    {
        public Coal() : base(nameof(Coal)) { }
    }

    public class Iron : Resource
    {
        public Iron() : base(nameof(Iron)) { }
    }

    public abstract class Building
    {
        public string Name;

        public Building(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return Name.Equals(obj);
        }
    }

    public class CoalDrill : Building
    {
        public CoalDrill() : base("Coal Drill") { }

        public Coal Mine()
        {
            return new Coal();
        }
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
