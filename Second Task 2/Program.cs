using System;
using System.Collections.Generic;
using System.Linq;

namespace Second_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            int K = numbers[0];
            int N = numbers[1];
            int temp = K;
            int counter = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (counter == 1)
                {
                    temp = K + 1;
                    result.Add(temp);
                    counter++;
                    continue;
                }
                else if (counter == 2)
                {
                    temp = 2 * K + 1;
                    result.Add(temp);
                    counter++;
                    continue;
                }
                else if (counter == 3)
                {
                    temp = K + 2;
                    result.Add(temp);
                    counter = 1;
                    K = result[result.Count / 3 - 1];
                    continue;
                }
                counter++;
            }
            Console.WriteLine(temp);
        }
    }
}
