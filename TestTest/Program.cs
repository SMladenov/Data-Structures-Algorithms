using System;

namespace TestTest
{
    internal class Program
    {
        public static void RecursiveFunction(int n)
        {
            if (n == 0) return;

            Console.Write(n);
            RecursiveFunction(n - 1);
        }
        public static void Main()
        {
            RecursiveFunction(10);
        }

    }
}
