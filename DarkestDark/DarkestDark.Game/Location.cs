using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DarkestDark.Game
{
    public class Location
    {
        public static List<Location> ReadLocations(string path)
        {
            var json = File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<List<Location>>(json);
            return result;
        }

        public string Name;
        public string Content;
        public string Options;
    }
}
