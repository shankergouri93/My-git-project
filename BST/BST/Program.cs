using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Console.ReadLine().Split(' '). Select(x => Convert.ToInt32(x));
            foreach (var item in numbers)
            {
                Node node = new Node(item);
                Push(node, Tree);
            }
            List<int> path = new List<int>();
            BSTTraverse(Tree, path);
        }
        static void BSTTraverse(Node node, List<int> path)
        {
            path.Add(node.Value);
            if (node.Left != null)
            {
                BSTTraverse(node.Left, path);
            }
            if (node.Right != null)
            {
                BSTTraverse(node.Right, path);
            }
            return;
        }
        static Node Tree { get; set; }
        static void Push(Node node, Node parent)
        {
            if (parent == null)
            {
                Tree = node;
            }
            else if (node.Value > parent.Value)
            {
                if (parent.Right == null)
                {
                    parent.Right = node;
                }
                else
                {
                    Push(node, parent.Right);
                }
            }
            else
            {
                if (parent.Left == null)
                {
                    parent.Left = node;
                }
                else
                {
                    Push(node, parent.Left);
                }
            }
        }
        public class Node
        {
            public Node(int value)
            {
                this.Value = value;
            }
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}
