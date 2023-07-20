using System;

namespace Sum_Digits
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
            if (n == 0)
            {
                return 0;
            }

            return n % 10 + Recursive(n/10);
        }
    }
}
