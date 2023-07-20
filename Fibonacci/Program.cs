using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] array = new long[n + 1];
            Console.WriteLine(RecursiveWithArray(n, array));

            //Console.WriteLine(Recursive(n, 0, 1));

        }

        public static long RecursiveWithArray(long n, long[] array)
        {

            if (array[n] == 0)
            {
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }

                array[n] = RecursiveWithArray(n - 1, array) + RecursiveWithArray(n - 2, array);
            }
            return array[n];
        }
        //public static long Recursive(int n, int prev, int current)
        //{

        //    if (n == 1)
        //    {
        //        return current;
        //    }

        //    return Recursive(n - 1, current, prev + current);
        //}
    }
}
