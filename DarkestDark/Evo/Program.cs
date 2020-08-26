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
        public string CellFormat;
        public Dictionary<Point, string> Elements;

        public GridWorld(int width, int height, string cell)
        {
            Height = height;
            Width = width;
            CellFormat = cell;
        }

        public void PrintWorld()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int t = 0; t < Width; t++)
                {
                    Console.Write(string.Format(CellFormat, " "));
                }
                Console.WriteLine();
            }
        }

        public Dictionary<Point, string> AddElement(Point elePoint, string eleStr)
        {
            Elements.Add(elePoint, eleStr);

            return Elements;
        }
    }

    class Program
    {
        private static Point startingPoint;

        static void Main(string[] args)
        {
            //World currentWorld = new World(new List<string> { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]",
            //"[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]",});

            //currentWorld.PrintWorld();

            var gw = new GridWorld(5, 5, "[{0}]");
            gw.PrintWorld();
            startingPoint = new Point(0, 0);
            gw.AddElement(startingPoint ,"[o]");

            // I want to the PrintWorld function to check for Elements != null.
            // Then print it along with the rest of the grid. 
        }
    }
}
