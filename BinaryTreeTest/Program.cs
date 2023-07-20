using System;

namespace BinaryTreeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var root = new Node(5);
            root.left = new Node(3);
            root.left.left = new Node(2);
            root.left.right = new Node(4);
            root.right = new Node(7);
            root.right.left = new Node(6);
            root.right.right = new Node(8);


            Method(root);

            //Output: 2,4,6,8 ----- Only the bottom line

        }

        public static void Method(Node root)
        {
            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.Value);
            }

            if (root.left != null)
            {
                Method(root.left);
            }

            if (root.right != null)
            {
                Method(root.right);
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
        public Node left { get; set; }
        public Node right { get; set; }

    }
}
