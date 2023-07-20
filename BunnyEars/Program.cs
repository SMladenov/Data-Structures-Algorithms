using System;

namespace BunnyEars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveMultiplication2(n));
        }

        public static int RecursiveMultiplication2(int number)
        {

            if (number < 1)
            {
                return 0;
            }

            return 2 + RecursiveMultiplication2(number - 1);
        }
    }
}
