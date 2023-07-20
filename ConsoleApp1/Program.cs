using LinkedList;
using System;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            node1.Next = node2;
            node2.Next = node3;

            var node4 = new Node<int>(1);
            var node5 = new Node<int>(2);
            var node6 = new Node<int>(3);
            node4.Next = node5;
            node5.Next = node6;

            AreListsEqual<int>(node1, node4);

            Console.WriteLine(node1.Value);
        }
        public static bool AreListsEqual<T>(Node<int> list1, Node<int> list2)
        {
            while (true)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.Value == list2.Value)
                    {
                        list1 = list1.Next;
                        list2 = list2.Next;
                    }
                }
            }
            
        }

    }
}