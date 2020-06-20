using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SandBox
{
    public class InputLine
    {
        public List<string> Names;
        public string Location;
        public List<string> bloops;
    }
    public class OutputLine
    {
        public string Name;
        public string Location;
        public bool IsDead;
    }

    class Program
    {
        public static List<InputLine> ReadInput(string s)
        {
            List<InputLine> result = new List<InputLine>();
            // Split string into lines and save
            var lines = s.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Massage array of strings into a list of Inputlines 
            foreach (var line in lines)
            {
                var parts = line.Split('@', '&');
                var location = parts.Last();
                var names = parts.Take(parts.Length - 1);
                InputLine item = new InputLine();
                // Turn the contents of names into a list and save it into Names field of item
                item.Names = names.ToList();
                item.Location = location;
                result.Add(item);
            }

            // return a list of InputLines
            return result;
        }
        static void Main(string[] args)
        {
            string s = @"Moshe @ Israel 
                        Boris! & Marisa @ Russia
                        Halil & Lara & Ford @ Egypt";

            var inputLines = ReadInput(s);

            var outputlines = Massage(inputLines);

            // Print output
            PrintOutput(outputlines);
        }
        private static List<OutputLine> Massage(List<InputLine> inputLines)
        {
            List<OutputLine> result = new List<OutputLine>();

            foreach (var line in inputLines)
            {
                foreach (var name in line.Names)
                {
                    OutputLine temp = new OutputLine();
                    temp.Name = name.Trim().Trim('!');
                    temp.IsDead = name.Contains("!");
                    temp.Location = line.Location.Trim();
                    result.Add(temp);
                }
            }
            return result;
        }

        private static void PrintOutput(List<OutputLine> outputLines)
        {
            foreach (var line in outputLines)
            {
                if (line.IsDead)
                {
                    Console.WriteLine($"{line.Name} is dead in {line.Location}");
                }
                else
                {
                    Console.WriteLine($"{line.Name} is in {line.Location}");
                }
            }
        }
    }
}
