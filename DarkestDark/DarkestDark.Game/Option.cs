using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DarkestDark.Game
{
    public class Option
    {
        public static List<Option> ReadOptions(string path)
        {
            var json = File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<List<Option>>(json);                                 
            return result;
        }

        public string Name;
        public string Content;
        public string Destination;
    }
}
