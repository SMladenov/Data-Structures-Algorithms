using System;

namespace Count_Occurancies_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursion(n, 7));
        }

        public static int Recursion(int n, int k)
        {
            if (n == 0)
            {
                return 0;
            }

            int digit = n % 10;
            if (digit == k)
            {
                return 1 + Recursion(n / 10, k);
            }
            else
            {
                return Recursion(n / 10, k);
            }
        }
    }
}
