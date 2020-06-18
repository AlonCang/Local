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
                var names = parts.Take(parts.Length -1);
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
                        Boris & Marisa @ Russia
                        Halil & Lara & Ford @ Egypt";

            var inputLines = ReadInput(s);

            var outputlines = Massage(inputLines);

            // Print output
            PrintOutput(outputlines);
        }

        // 1st try.
        // I dont think i need to do any data conversion. Thats why this went nowhere.

        // private static List<OutputLine> Massage(List<InputLine> inputLines)
        //{
        //    List<InputLine> result = new List<InputLine>(inputLines);

        //    foreach (var line in inputLines)
        //    {
        //        List<string> tempNames = line.ToString();

        //    }
        //}

        private static List<OutputLine> Massage(List<InputLine> inputLines)
        {
            List<InputLine> input = inputLines;
            List<OutputLine> result = new List<OutputLine>();

            // I want to populate the result.Name field with the value 
            // of a single name from inputlines
            foreach (var line in inputLines)
            {
                
                OutputLine temp = new OutputLine();
                temp.Name = input
            }



        }

        private static void PrintOutput(List<OutputLine> outputLines)
        {
            throw new NotImplementedException();
        }



        // This is one attempt that i couldnt finalize.
        // Replace() cant accept more than a single character as an argument

        //{
        //    string[] parts = "Moshe @ Israel".Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        //    for (int i = 0; i < parts.Length; i++)
        //    {
        //        var str = parts[i];
        //        if (str == "@")
        //        {
        //           parts[i] = str.Replace("@", "is in");
        //        }
        //    }
        //    string value = string.Join(" ", parts);
        //    Console.WriteLine(value);
        //    Console.Read();

        //}

        // -----------------------------------------------------------------------------------------------------

        // Now second attempt:
        // Looks like the Replace() cannot accept interpolation as part of its arguments.
        // Need to try another angle.

        //{
        //    //string
        //    string OldString = "Moshe @ Israel";
        //    Console.WriteLine("OldString: " + OldString);

        //    // Replace the character '@' with 'I'
        //    Console.WriteLine("NewString: " + OldString.Replace('@', 'I'));

        //    string key = "is in";

        //    Console.WriteLine($"NewString: " + OldString.Replace("@", key));

        //    Console.Read();
        //}
        //-------------------------------------------------------------------------------------------------------


        // Third attempt.
        // Stack overflow either lies to me or i dont get how to use this function.

        //{
        //    Console.WriteLine("Moshe @ Israel".Replace("@", "is in"));
        //    Console.Read();
        //}

        //-------------------------------------------------------------------------------------------------------

        //forth attempt.
        // Had to add Regular expresions pack for this one.
        // I still dont really understand what that means.
        // still cant get the required outcome.
        //{
        //    string input = "Moshe @ Israel";
        //    string pattern = @"\b@\b";
        //    string replace = "is in";
        //    string result = Regex.Replace(input, pattern, replace);
        //    Console.WriteLine(result);
        //    Console.Read();
        //}
    }


    // This code block is for how to parse a tree.

    //class TreeNode
    //{
    //    public List<TreeNode> nodes;

    //    public static int FindDepth(TreeNode root)
    //    {
    //        if (root.nodes.Count == 0)
    //        {
    //            return 1;
    //        }
    //        return 1 + root.nodes.Select(FindDepth).Max();
    //        //foreach (var node in root.nodes)
    //        //{

    //        //    A
    //        //   /  \
    //        //  B1    C
    //        //        |
    //        //        D1
    //        //}

    //        // O O O
    //        // O O O
    //        // O O O
    //        // [O,O,O,O,O,O,O,O,O,O,]
    //        char[,] matrix = new char[3, 3];
    //    }
    //}
}
