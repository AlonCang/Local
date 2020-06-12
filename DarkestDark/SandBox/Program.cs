using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SandBox
{
    public enum fu
    {
        a1,
        asd,
        asdasdas,
        x,

    }
    class Program
    {
        static void Main(string[] args)


        // This is one attempt that i couldnt finalize.
        // Replace() cant accept more than a single character as an argument

        //{
        //    string[] parts = "Moshe @ Israel".Split(new[] { " " } , StringSplitOptions.RemoveEmptyEntries);
        //    foreach (var str in parts)
        //    {
        //        if (str == "@")
        //        {
        //            parts.Replace('@', 'is in')
        //            {
        //             string value = string.Join(" ", parts);
        //             Console.WriteLine(value);

        //            }
        //        }
        //    }
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

        //    Console.WriteLine($"NewString: " + OldString.Replace('@', {key});

        //    Console.Read();
        //}
        //-------------------------------------------------------------------------------------------------------


        // Third attempt.
        // Stack overflow either lies to me or i dont get how to use this function.

        //{
        //    string[] parts = "Moshe @ Israel".Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        //    parts.Replace(@"\b@\b", "is in");
        //    string value = string.Join(" ", parts);
        //    Console.WriteLine(value);


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
