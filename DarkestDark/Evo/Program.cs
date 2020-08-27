using System;
using System.Collections.Generic;
using System.Drawing;

namespace Evo
{
    //class World
    //{
    //    public List<string> Spaces;
    //    public List<string> Creatures;
    //    public List<string> WorldData;

    //    public World(List<string> data)
    //    {
    //        string line = "";
    //        WorldData = new List<string>();
    //        int sizeLimit = 0;
    //        foreach (var space in data)
    //        {
    //            if (sizeLimit < 5)
    //            {
    //                line += space;
    //                sizeLimit++;
    //            }
    //            else
    //            {
    //                WorldData.Add(line);
    //                sizeLimit = 0;
    //                line = "";
    //            }
    //        }
    //    }

    //    public void PrintWorld()
    //    {
    //        foreach (var line in WorldData)
    //        {
    //            Console.WriteLine($"{line} \n");
    //        }
    //    }
    //}

    class GridWorld
    {
        public const string EmptySpace = " ";

        public int Width;
        public int Height;
        public string EmptyCellFormat;
        public Dictionary<Point, string> Elements = new Dictionary<Point, string>();

        public GridWorld(int width, int height, string cell)
        {
            Height = height;
            Width = width;
            EmptyCellFormat = cell;
        }

        public void PrintWorld()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Point bla = new Point(x, y);
                    if (Elements.ContainsKey(bla))
                    {
                        Console.Write(string.Format(EmptyCellFormat, Elements[bla]));
                    }
                    else
                    {
                        Console.Write(string.Format(EmptyCellFormat, " "));
                    }
                }
                Console.WriteLine();
            }
        }

        
    }

    class Program
    {

        static void Main(string[] args)
        {
            //World currentWorld = new World(new List<string> { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]",
            //"[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]",});

            //currentWorld.PrintWorld();

            var gw = new GridWorld(5, 5, "[{0}]");
            var startingPoint = new Point(1, 0);
            gw.Elements.Add(startingPoint ,"o");
            gw.PrintWorld();

            // I want to the PrintWorld function to check for Elements != null.
            // Then print it along with the rest of the grid. 
        }
    }
}
