using System;

namespace FactorialRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(FactorialRecursion(n));
        }

        public static int FactorialRecursion(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            else
            {
                return number * FactorialRecursion(number - 1);
            }
        }
    }
}
