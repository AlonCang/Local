using System;

namespace Factorio.Mess
{
    public class Buildings
    {
        public static Building BuildCoalDrill()
        {
            return new CoalDrill();
        }

        public static Building BuildIronDrill()
        {
            return new IronDrill();
        }
    }
    public class Mining
    {
        public static Resource MineCoal()
        {
            return new Coal();
        }

        public static Resource MineIron()
        {
            return new Iron();
        }
    }
    class Program
    {
        static void Main(string[] args)
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
                    var result2 = Buildings.BuildIronDrill();
                    Console.WriteLine($"You no have 1 {result2.Name}");
                }
                else
                {
                    var result2 = Buildings.BuildCoalDrill();
                    Console.WriteLine($"You no have 1 {result2.Name}");
                }
            }
            else
            {
                var result = Mining.MineCoal();
                Console.WriteLine($"You now have 1 {result.Name}");
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
