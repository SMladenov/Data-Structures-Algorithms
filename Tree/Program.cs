using System;
using TreeDemo;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Breadth-First Search (BFS) or Level Order Traversal
            //Explores by levels, Implemented with a queue, starting from the root and going down and print all numbers from left to right on each level

            //Depth-First Search(DFS)
            //Explores as far as possible along each child branch
            //Usually implemented with either recursion or a stack

            //In Binary Tree DFS we have 3 types of searches: Pre-Order, In-Order, Post-Order
            //In Binary Tree it is not necessary to have the lower values on the Left and on the Right higher values

            //Binary Search Tree - Left from the Root is lower than the root and Right from the Root is larger than the root
            //This is the same way when going through the tree and having different root all the way down

            var root = new BinaryTreeNode(6);
            root.Left = new BinaryTreeNode(5);
            root.Right = new BinaryTreeNode(2);

            root.Left.Left = new BinaryTreeNode(8);
            root.Left.Right = new BinaryTreeNode(3);

            root.Right.Left = new BinaryTreeNode(1);
            root.Right.Right = new BinaryTreeNode(7);


            //Console.WriteLine("Pre-Order:");
            //Console.WriteLine("In-Order:");
            Console.WriteLine("Post-Order:");
            //PreOrder(root);
            //InOrder(root);
            PostOrder(root);

        }

        //PreOrder
        static void PreOrder(BinaryTreeNode root)
        {
            Console.WriteLine($"{root.Value}");

            if (root.Left != null)
            {
                PreOrder(root.Left);
            }

            if (root.Right != null)
            {
                PreOrder(root.Right);
            }

        }

        //InOrder

        static void InOrder(BinaryTreeNode root)
        {

            if (root.Left != null)
            {
                InOrder(root.Left);
            }

            Console.Write($"{root.Value} ");

            if (root.Right != null)
            {
                InOrder(root.Right);
            }
        }

        // PostOrder

        static void PostOrder(BinaryTreeNode root)
        {
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }

            if (root.Right != null)
            {
                PostOrder(root.Right);
            }

            Console.Write($"{root.Value} ");
        }
    }
}
