using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split(", ").ToList();

            int counter = 0;
            string word = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                string currentWord = input[i];

                for (int j = 0; j < input.Count; j++)
                {
                    if (currentWord.Equals(input[j]))
                    {
                        counter++;

                    }
                    
                }
                Console.WriteLine($"{currentWord} |{new string('*', counter)}");
                counter = 0;
            }

        }
    }
}
