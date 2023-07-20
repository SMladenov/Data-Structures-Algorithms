using System;
using System.Collections.Generic;
using System.Linq;

namespace StudenOrderThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> names = Console.ReadLine().Split(' ').ToList();
            int seatChanges = int.Parse(input.Split(' ')[1]);
            //Stanka Miro Tosho Penka Gosho

            var firstNode = new Node(names[0]);
            var tempNode = firstNode;
            var dic = new Dictionary<string, Node>();
            dic.Add(names[0], tempNode);


            for (int i = 1; i < names.Count; i++)
            {
                var node = new Node(names[i]);
                dic.Add(names[i], node);
                firstNode.Next = node;
                node.Prev = firstNode;
                firstNode = node;
            }

            for (int i = 0; i < seatChanges; i++)
            {
                var sw = Console.ReadLine().Split(' ').ToList();
                var firstName = sw[0];
                var secondName = sw[1];

                var fNode = dic[firstName];

                //remove element
                var fNodePrev = fNode.Prev;
                var fNodeNext = fNode.Next;

                if (fNodePrev != null)
                {
                    fNodePrev.Next = fNodeNext;
                }
                if (fNodeNext != null)
                {
                    fNodeNext.Prev = fNodePrev;
                }

                //add element
                var f2Node = dic[secondName];
                var f2NodePrev = f2Node.Prev;

                if(f2NodePrev != null)
                {
                    f2Node.Prev = fNode;
                    fNode.Next = f2Node;
                    fNode.Prev = f2NodePrev;
                    f2NodePrev.Next = fNode;
                }
                else
                {
                    fNode.Next = f2Node;
                    f2Node.Prev = fNode;
                    fNode.Prev = null;
                }
            }
            //Emo Ivanka Ginka Vancho Sashka Stancho Misho

            while (firstNode.Prev != null)
            {
                firstNode = firstNode.Prev;
            }


            do
            {
                Console.Write(firstNode.name + " ");
                firstNode = firstNode.Next;

            } while (firstNode != null);
        }
    }
    public class Node
    {
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public string name;
        public Node(string name)
        {
            this.name = name;
        }

    }


}
