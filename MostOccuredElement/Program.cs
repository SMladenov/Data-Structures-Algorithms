using System;
using System.Collections.Generic;
using System.Linq;

namespace MostOccuredElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dic = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dic.ContainsKey(input[i]))
                {
                    dic.Add(input[i], 1);
                }
                else
                {
                    int value = dic[input[i]];
                    dic[input[i]] = value + 1;
                }
            }

            char resultChar = '\0';
            int resultInt = 0;

            foreach (var item in dic)
            {
                if (resultInt < item.Value)
                {
                    resultInt = item.Value;
                    resultChar = item.Key;
                }
            }

            Console.WriteLine($"Char \"{resultChar}\" with \"{resultInt}\" occurancies");
        }
    }
}
