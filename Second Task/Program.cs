using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Second_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int K = input[0];
            int N = input[1];
            //int minusN = int.MinValue;
            //if (N == 0)
            //{
            //    Console.WriteLine(0);
            //}
            //if (N < 0)
            //{
            //    int tempN = N;
            //    while (tempN < 0)
            //    {
            //        minusN = tempN + 7;
            //        tempN = minusN;
            //    }
            //}
            //if (N > 7)
            //{
            //    int index = 0;
            //    while (N > 7)
            //    {
            //        index = N - 7;
            //        N = index;
            //    }
            //}

            List<int> result = new List<int>();

            result.Add(K);
            int index1 = K + 1;
            result.Add(index1);
            int index2 = 2 * K + 1;
            result.Add(index2);
            int index3 = K + 2;
            result.Add(index3);
            int index4 = index1 + 1;
            result.Add(index4);
            int index5 = 2 * index1 + 1;
            result.Add(index5);
            int index6 = index1 + 2;
            result.Add(index6);

            int index = N % 7;
            if (N == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result[index - 1]);
            }



            //if (minusN > 0)
            //{
            //    Console.WriteLine(result[minusN - 2]);
            //}
            //if(N <= 7 && N != 0 && N > 0)
            //{
            //    Console.WriteLine(result[N - 1]);
            //}

        }
    }
}
