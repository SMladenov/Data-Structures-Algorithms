using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<Node>();

            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);

            linkedList.AddFirst(node3);
            linkedList.AddFirst(node2);
            linkedList.AddFirst(node1);

            var result = Method(node1, node3);

            Console.WriteLine(result.Value);
            Console.WriteLine(linkedList.Last.Value.Value);
            foreach (var node in linkedList) 
            {
                Console.WriteLine(node.Value);
            }
        }

        private static Node Method(Node n1, Node n2)
        {
            Node current = n1;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = n2;

            return n1;
        }
    }

    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
