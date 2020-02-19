using System;

namespace Factorio.Mess
{
    public class Buildings
    {
        public static void BuildDrill()
        { }
    }
    public class Mining
    {
        public static Resource MineCoal()
        {
            return new Coal();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is mining simulator. Drill for coal or build a drill?\n" +
                "1. drill manually like bitch\n" +
                "2. Build drill like boss");
            var c = Console.ReadLine();
            if (c == "2")
            {

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
}
