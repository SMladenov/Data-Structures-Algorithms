using System;
using System.Threading.Channels;

namespace FibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ItterativeFibonacci(7));
            //Console.WriteLine(Fibonacci(7));

            int n = int.Parse(Console.ReadLine());
            long[] array = new long[n + 1];
            Console.WriteLine(FibonacciWithMemorization(n, array));
        }

        static long FibonacciWithMemorization(long n, long[] array)
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

                array[n] = FibonacciWithMemorization(n - 1, array) + FibonacciWithMemorization(n - 2, array);
            }

            return array[n];
        }

        //time - 0(n)2, space 0(n)
        static long Fibonacci(long n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);


        }

        //time - 0(n), space 0(n)
        static long ItterativeFibonacci(int n)
        {
            long previous = 0;
            long result = 1;
            long current = 1;
             
            for (int i = 1; i < n; i++)
            {
                current = result;
                result = previous + current;
                previous = current;
            }

            return result;
        }

    }
}
