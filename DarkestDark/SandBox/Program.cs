using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        {
            string[] parts = "Aaa.Bbbbbbb,Cc".Split(new [] {".", "," }, StringSplitOptions.RemoveEmptyEntries);
            string value = string.Join(",", parts);
            Console.WriteLine(value);

        }
    }

    class TreeNode
    {
        public List<TreeNode> nodes;

        public static int FindDepth(TreeNode root)
        {
            if(root.nodes.Count == 0)
            {
                return 1;
            }
            return root.nodes.Select(FindDepth).Max() + 1;
            //foreach (var node in root.nodes)
            //{

            //    A
            //   /  \
            //  B1    C
            //        |
            //        D1
            //}
        }
    }
}
