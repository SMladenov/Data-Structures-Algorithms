using System;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursive(n));
        }

        public static int Recursive(int n)
        {

            if (n < 1)
            {
                return 0;
            }

            return n + Recursive(n - 1);
        }
    }
}
