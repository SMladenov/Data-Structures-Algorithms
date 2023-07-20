using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Noah_s_Ark
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                string specie = Console.ReadLine();

                if (!dic.ContainsKey(specie))
                {
                    dic.Add(specie, 1);
                }
                else
                {
                    int value = dic[specie];
                    dic[specie] = value + 1;
                }
            }

            foreach (var item in dic.OrderBy(i => i.Key))
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine($"{item.Key} {item.Value} Yes");
                }
                else
                {
                    Console.WriteLine($"{item.Key} {item.Value} No");
                }
            }

        }
    }
}
