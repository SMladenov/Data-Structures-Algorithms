using System;
using System.Collections.Generic;

namespace QueueTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);


            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Peek());

        }
    }
}
