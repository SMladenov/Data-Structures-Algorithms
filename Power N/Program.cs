using System;

namespace Power_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursive(n, p));
        }

        public static int Recursive(int n, int p)
        {
            if (p == 0)
            {
                return 1;
            }

            return n * Recursive(n, p - 1);

        }
    }
}
