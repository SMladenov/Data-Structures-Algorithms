using System;

namespace BunnyEars2
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
            else if (n % 2 == 1)
            {
                return 2 + Recursive(n - 1);
            }
            else
            {
                return 3 + Recursive(n - 1);
            }
        }
    }
}
