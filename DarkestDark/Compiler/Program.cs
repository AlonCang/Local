using System;

namespace Compiler
{
    // In this project i will start trying to write a compiler
    class Program
    {
        static void Main(string[] args)
        {
            // Is this similar to a repl loop?
            while (true)
            {
                Console.Write(">");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                    return;

                var lexer = new Lexer(line);
                while (true)
                {
                    var token = lexer.NextToken();
                    if (token.Kind == SyntaxKind.EndOfFileToken)
                        break;
                    Console.Write($"{token.Kind}: '{token.Text}'");
                    if (token.Value != null)
                        Console.Write($" {token.Value}");

                    Console.WriteLine();
                }
            }
        }
    }
}
