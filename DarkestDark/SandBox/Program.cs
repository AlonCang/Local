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
    }
    public class OutputLine
    {
        public string Name;
        public string Location;
        public bool IsDead;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = @"Moshe @ Israel 
                        Boris! & Marisa @ Russia
                        Halil & Lara & Ford @ Egypt";
            var inputLines = ReadInput(s);
            var outputlines = Massage(inputLines);
            PrintOutput(outputlines);
        }

        /// <summary>
        /// Massage text <see cref="string"/> into <see cref="InputLine"/>s.
        /// </summary>
        /// <param name="inputText">Content of entire file(s) (incl. \n \r).</param>
        /// <returns>An enumeration over <see cref="InputLine"/>s.</returns>
        public static IEnumerable<InputLine> ReadInput(string inputText)
        {
            foreach (var line in inputText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var parts = line.Split('@', '&');
                yield return new InputLine
                {
                    Names = parts.Take(parts.Length - 1).ToList(),
                    Location = parts.Last()
                };
            }
        }
        /// <summary>
        /// Massage <see cref="InputLine"/>s into <see cref="OutputLine"/>s.
        /// </summary>
        /// <param name="inputLines"></param>
        /// <returns></returns>
        private static IEnumerable<OutputLine> Massage(IEnumerable<InputLine> inputLines)
        {
            foreach (var line in inputLines)
            {
                foreach (var name in line.Names)
                {
                    yield return new OutputLine
                    {
                        Name = name.Trim('!', ' ', '\t'),
                        IsDead = name.Contains("!"),
                        Location = line.Location.Trim()
                    };
                }
            }
        }

        /// <summary>
        /// Display all <see cref="OutputLine"/>s.
        /// </summary>
        /// <param name="outputLines">An enumeration of <see cref="OutputLine"/>s.</param>
        private static void PrintOutput(IEnumerable<OutputLine> outputLines)
        {
            foreach (var line in outputLines)
            {
                Console.WriteLine($"{line.Name} is {(line.IsDead ? "dead" : "")} in {line.Location}");
            }
        }
    }
}
