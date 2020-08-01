using System;
using System.Collections.Generic;
using System.Drawing;

namespace Evo
{
    class World
    {
        public List<string> spaces;
        public List<string> creatures;
        public List<string> world;
        public List<string> LoadWorld(List<string> spaces)
        {
            string line = "";
            List<string> world = new List<string>();
            int sizeLimit = 0;
            foreach (var space in spaces)
            {
                if (sizeLimit < 5)
                {
                line += space;
                sizeLimit++;
                }
                else
                {
                    world.Add(line);
                    sizeLimit = 0;
                    line = "";
                }
            }
            return world;
        }

        public void PrintWorld(List<string> world)
        {
            foreach (var line in world)
            {
                Console.WriteLine($"{line} \n");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            World currentWorld = new World();
            List<string> worldData = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", });

            currentWorld.LoadWorld(worldData);
            currentWorld.PrintWorld(currentWorld.world);
            
           

        }
    }
}
