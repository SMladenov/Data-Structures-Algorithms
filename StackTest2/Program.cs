using System;
using System.Collections.Generic;

namespace StackTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stackTest = new Stack<int>();

            stackTest.Push(1);
            stackTest.Push(2);
            stackTest.Push(3);


            foreach (int item in stackTest)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stackTest.Peek());

        }
    }
}
