using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Recursion
{
    class Program
    {
        static void Main2(string[] args)
        {
            var letters = new string[] { "A", "B", "C", "D", "X" };
            Console.WriteLine("Hello World!");
            RecursiveAllWords(letters);
        }

        private static void RecursiveAllWords(string[] letters, string soFar = "")
        {
            if (letters.Length == 0)
            {
                Console.WriteLine(soFar);
                return;
            }
            string[] etters = letters.Skip(1).ToArray();
            RecursiveAllWords(etters, soFar + letters[0]);
            RecursiveAllWords(etters, soFar);
        }

        private int Factorial(int n)
        {
            if (n == 1) { return 1; }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            var tree = new BinaryTree
            {
                Root = new BinaryTreeNode
                {
                    Value = 7,
                    Left = new BinaryTreeNode
                    {
                        Value = 5,
                        Left = new BinaryTreeNode
                        {
                            Value = 2,
                            Right = new BinaryTreeNode { Value = 4 },
                        },
                        Right = new BinaryTreeNode { Value = 6 },
                    },
                    Right = new BinaryTreeNode
                    {
                        Value = 9,
                        Left = new BinaryTreeNode { Value = 8 },
                        Right = new BinaryTreeNode { Value = 10 },
                    },
                }
            };
        }
    }

    class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        
    }

    class BinaryTree
    {
        public BinaryTreeNode Root;

        public bool Exists(int num)
        {
            return RecuriseExists(Root, num);
        }

        public bool RecuriseExists(BinaryTreeNode aaaa, int num) {

            if (aaaa.Value == num)
            {
                return true;
            }
            else if (num < aaaa.Value && aaaa.Left != null)
            {
                return RecuriseExists(aaaa.Left, num);
            }
            else if (num > aaaa.Value && aaaa.Right != null)
            {
                return RecuriseExists(aaaa.Right, num);
            }
            else
            {
                return false;
            }
        }
    }




}
